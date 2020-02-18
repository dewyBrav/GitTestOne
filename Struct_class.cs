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
            Console.WriteLine("\nВызов из класса: {0}", MT.NAmeCall);

            

        }

        private string NAmeCall
        {
            get
            {
                return GetType().Name;
            }
        }
    }
}

