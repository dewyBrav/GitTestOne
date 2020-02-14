using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class ref_out_params
    {

        public static void CallMethod()
        {
            ref_out_params MT = new ref_out_params();
            Console.WriteLine("\nВызов из класса: {0}", MT.NAmeCall);

            int ans = Add(10,7);
            Console.WriteLine($"Передаем два параметра и получаем результат: {ans}   - Передача  параметров по значению"); //передаем 2 значения

          //  int ans;
            Add(20,14, out ans);
            Console.WriteLine($"Передаем два параметра и получаем результат: {ans}   - Модификатор out");


            string str = "PC", str2 = "Mac";
            Console.WriteLine($"Меняем местами две строки: 1 - {str} , 2 - {str2}   - Модификатор ref");
            SwapStrings(ref str, ref str2);
            Console.WriteLine("После изменения: 1- {0}, 2 - {1}", str, str2);

            Console.WriteLine("Получение среднего значения из массива  - params -передача массива параметор ");
            double[] data = { 4.0, 5.3, 7.8, 64.22, 101, 67, 15.0, 9 };
            
            Console.WriteLine("Передача массива с парамтрами: {0}", data);
            double average = CalculateAverage(data);
            Console.WriteLine($"Среднее значение из average: {average}");

        }


        static double CalculateAverage(params double[] values)

        {
            Console.WriteLine("Размер полученных значении {0} doubles", values.Length);

            double sum = 0;
            if (values.Length == 0) return sum;
            for(int i = 0; i<values.Length; i++)
            {
                sum += values[i];

            }
            return (sum / values.Length);


        }



        private static int Add(int x, int y)
        {
            int ans = x + y;

            return ans;
        }

        private static void  Add(int x, int y, out int ans) //out
        {
            ans = x + y;

            
        }
        private static void SwapStrings(ref string s1, ref string s2)//ref
        {
            string tmp = s1;
            s1 = s2;
            s2 = tmp;


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
