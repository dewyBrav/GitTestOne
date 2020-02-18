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
            Console.WriteLine("HELOOO");
            DelegateTest.Call_delegate();

            MyTestClassOne.MyTestClass();

            LINQtest.MethodLINQ();

            ref_out_params.CallMethod();

            TestMethods.Function_one();

            My_Array.CallMethod();

            Enum_class.CallMethod();


            Struct_class.CallMethod();
            Console.ReadKey();
        }

        

        

        
    }
}
