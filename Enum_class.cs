using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Enum_class
    {
        public static void CallMethod()
        {

            Enum_class MT = new Enum_class();
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
