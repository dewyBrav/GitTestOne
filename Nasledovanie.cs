using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Nasledovanie
    {

        public static void Nasledovanie1()
        {
            Nasledovanie MT = new Nasledovanie();
            Console.WriteLine("\n\nВызов из класса: {0}", MT.Names);
            Vivod();
        }


        public static void Vivod()
        {
            Car c1 = new Car();
            Console.WriteLine($"{c1.maxSpeed}   {c1.Speed}");

            c1.Speed = 90;
            Console.WriteLine($"{c1.maxSpeed}   {c1.Speed}") ;

            c1.Speed = 30;
            Console.WriteLine($"{c1.maxSpeed}   {c1.Speed}");



            MashineOne m1 = new MashineOne();
            Console.WriteLine($"{m1.maxSpeed}   {m1.Speed}");

            m1.Speed = 80;
            Console.WriteLine($"{m1.maxSpeed}   {m1.Speed}");

            m1.Speed = 22;
            Console.WriteLine($"{m1.maxSpeed}   {m1.Speed}");

            Console.WriteLine($"{c1.maxSpeed}   {c1.Speed}");



        }


        string Names
        {

            get
            {
                return GetType().Name;
            }
        }



    }


     class Car
    {
        public readonly int maxSpeed;
        protected int currSpeed;
        public Car(int max) { maxSpeed = max; }
        public Car() { maxSpeed = 55; }

        public virtual int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }

            }

        }

    }

    class MashineOne:Car
    {


        public override int Speed
        {

            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed+2;
                }

            }
        }


    }

     class MashineTwo:Car
    {
    }
}
