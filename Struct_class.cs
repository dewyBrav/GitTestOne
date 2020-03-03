using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Struct_class
    {


        public static void CallMethod()
        {

            Struct_class MT = new Struct_class();
            Console.WriteLine("\n\nВызов из класса: {0}", MT.NAmeCall);


            Funv f1 = new Funv("GUS", 1,2,30);
            Funv f2 = f1;

            f2.TT.mess1 = "UTKA";
            f2.one = 101;
            f1.Display();
            f2.Display();

            
        }
        
        private string NAmeCall
        {
            get
            {
                return GetType().Name;
            }
        }
    }

    struct Funv
    {

        public int one, two, three;
        public Info TT;
        public Funv(string soob, int oo, int tt, int tr)
        {
            one = oo;
            two = tt;
            three = tr;
            TT = new Info(soob);

        }
        public void Display()
        {
            Console.WriteLine($"{one}  {two}  {three}  {TT.mess1}");

        }

    }
    class Info
    {

        public string mess1;
        public Info(string m1)
        {

            mess1 = m1;
        }


    }
}

