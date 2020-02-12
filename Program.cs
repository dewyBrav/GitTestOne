using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Program

    {

        delegate void delgate(string m);
        static void Main(string[] args)
        {
            delgate d1 = ClassStringTest;
            d1?.Invoke(null);





            Console.ReadKey();
        }


        public static void ClassStringTest(string ms)
        {
            string mess1= ms;

            string sForm = String.Format($"String.Format is :{mess1}, Data now: {DateTime.Now}");
            Console.WriteLine(sForm);
        }
    }
}
