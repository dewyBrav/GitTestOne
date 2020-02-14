using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class TestMethods
    {

        public static void Function_one()
        {
            TestMethods TM = new TestMethods();
            Console.WriteLine("\nВызов из класса: {0}", TM.NAmeCall);



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

