using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    public class My_Array
    {

        public static void CallMethod()
        {

            My_Array MT = new My_Array();
            Console.WriteLine("\nВызов из класса: {0}", MT.ArrayCall);

            Arr_method();

        }

        static void Arr_method()
        {

            string[] mess = {"one","two","five","nine" };
            Console.WriteLine($"Размер массива: {mess.Length}\t Значение:");
            
            foreach(var s in mess)
            {
                Console.Write(s+"\t");
            }

            Console.WriteLine("\nметод Reverse:");
            Array.Reverse(mess);
            foreach (var s in mess)
            {
                Console.Write(s + "\t");
            }


            

        }



private string ArrayCall
    {
        get
        {
            return GetType().Name;
        }
    }
    }
    
}
