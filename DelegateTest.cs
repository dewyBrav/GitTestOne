using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
     class DelegateTest
    {
        delegate void delgate(string m);
        DelegateTest d_class = new DelegateTest();


        public static void Call_delegate ()
        {
            
            delgate d1 = ClassStringTest;
            Console.WriteLine("\nВызов из класса: {0}", d1.GetType().FullName);
            d1?.Invoke("HI");

        }


         static void ClassStringTest(string ms)
        {
            string mess1 = ms;

            string sForm = String.Format($"String.Format is :{mess1}, Data now: {DateTime.Now}");
            StringBuilder nes = new StringBuilder(sForm);
            nes.Append(" !!!!!");

            
            Console.WriteLine(nes);
        }
    }
}
