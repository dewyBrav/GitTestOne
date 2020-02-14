using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Program

    {

        
        static void Main(string[] args)
        {

            DelegateTest.Call_delegate();

            MyTestClassOne.MyTestClass();

            LINQtest.MethodLINQ();

            TestMethods.Function_one();

            Console.ReadKey();
        }

        

        

        
    }
}
