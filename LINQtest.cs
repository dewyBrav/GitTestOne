using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class LINQtest
    {

        public static void MethodLINQ()
        {
            LINQtest LT = new LINQtest();

            Console.WriteLine("\nВызов из класса: {0}", LT.LINQCall );
            int[] massiv = { 0, 1, 3, 5, 8, 11, 45, 6, 12, 15 };
            var subject = from i in massiv where i < 10 select i;
            foreach (var i in subject)
            {
                Console.Write($"{i} ");
            }
        }

        public  string LINQCall
        {
            get
            {
                return GetType().Name;
            }
        }

    }
}
