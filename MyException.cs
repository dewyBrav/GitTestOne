using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class MyException
    {
        public static void CallMethod()
        {

            MyException MT = new MyException();
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

