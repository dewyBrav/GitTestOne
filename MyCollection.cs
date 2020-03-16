using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace GitTestOne
{
    partial class MyCollection
    {
        public MyCollection()
        {
           // VremyaVipolnenia();//проверяем скорость двух методов. 1(ArrayList) - упоковка распоковка, 2(List<T>) - через обобщение

            Obobchenie_arraylist(); //

        }

        private static void VremyaVipolnenia()
        {
            Console.WriteLine("Проверяем скорость двух методов. 1(ArrayList) - упоковка распоковка, 2(List<T>) - через обобщение");
            MyArrayList MA = new MyArrayList();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            MyCollection<int>.SimpleBoxUnboxOperation();
            sw.Stop();
            Console.WriteLine("boxing/unboxing: " + sw.ElapsedMilliseconds);
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            MyCollection<int>.TOperation();
            sw.Stop();
            Console.WriteLine("обощенный метод<T>: " + sw2.ElapsedMilliseconds);
        }

        private static void Obobchenie_arraylist()
        {
            Console.WriteLine("\nМетод Obobchenie_arraylist");
            List<string> L1 = new List<string>();
            L1.Add("hello"); L1.Add("hello1"); L1.Add("hello2");

            List<int> L2 = new List<int>();
            L2.Add(5); L2.Add(10); L2.Add(23);

            List<Manager> L3 = new List<Manager>();
            L3.Add(new Manager("Tom", 18, 0955, 30.55f, "57-654", 0));  //string fullName, int age, int empID, float cuurPay, string ssn, int numbOfOpts
            L3.Add(new Manager("Hardy", 29, 7689, 21.22f, "67-653", 1));
            L3.Add(new Manager("Angel", 45, 11235, 54.67f, "57-654", 5));

            ArrayList Ar = new ArrayList();
            Ar.Add(L1); Ar.Add(L2); Ar.Add(L3);

            //Console.WriteLine("Count ArrayList Ar: {0}", Ar.Count);
            foreach (var a in Ar)
            {

                Console.WriteLine(a.GetType());
                if (a is List<string> r)
                {
                    Console.WriteLine("-----------");
                    for (int i = 0; i < r.Count; i++)
                    {
                        Console.WriteLine(r[i]);
                    }
                }
                if (a is List<int> y)
                {
                    Console.WriteLine("-----------");
                    for (int i = 0; i < y.Count; i++)
                    {
                        Console.WriteLine(y[i]);
                    }
                }
                if (a is List<Manager> u)
                {
                    Console.WriteLine("-----------");
                    for (int i = 0; i < u.Count; i++)
                    {
                        Console.Write("Менеджер: {0}\t", i+1);
                        u[i].DisplayStats();
                    }
                }
                //  else Console.WriteLine(a.ToString());

            }
        }





    }



        class MyArrayList
        {
            ArrayList myAL = new ArrayList();
            Manager _mgr = new Manager();
            public MyArrayList()
            {

                myAL.Add("Hello");
                myAL.Add("World");
                myAL.Add("!");
                myAL.Add(11);
                myAL.Add(_mgr);
                PrintInfoList(myAL);

                ArrayList arr2 = (ArrayList)myAL.Clone();

                arr2.AddRange(myAL);
                arr2.RemoveAt(4);
                PrintInfoList(arr2);

            }

            public static void PrintInfoList(ArrayList ar)
            {
                int _count = ar.Count;
                string _nameClass = ar.GetType().Name;
                Console.WriteLine("Экземпляр класса {0} имеется размер {1}, включает в себя типы данных:", _nameClass, _count);
                foreach (var a in ar)
                {
                    if (a is Manager r)
                    {
                        Console.WriteLine(r.GetType());
                        r.DisplayStats();
                    }

                    else Console.WriteLine(a.GetType());
                }

            }

        }




    }

