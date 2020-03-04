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


            Console.WriteLine("\nРабота с классами partial Employee");
            EmployClassWordk();


        }
        static void EmployClassWordk()
        {
            Console.WriteLine("Работа с клссами Employee, Manager, SalesPerson\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            //Console.WriteLine($"Age { fred.Age}, Name: {fred.Name}, SaleNumber {fred.SalesNumber}");
            fred.DisplayStats();

            Manager chucky = new Manager("Chucky", 50, 92, 10000, "3333-23-2121", 9000);
            double cost = chucky.GetBenefitCost();
            //Console.WriteLine($"Age { chucky.Age}, Name: {chucky.Name}, ID {chucky.ID}, PAY {chucky.Pay}, SocialNumber {chucky.SocialSecNumber}, StackOption {chucky.StockOption}, Cost {cost}");
            chucky.GiveBonus(300);
            chucky.DisplayStats();

            Console.WriteLine();
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();





            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;

        }

        public static void Vivod()
        {
            Car c1 = new Car();
            Console.WriteLine($"МАКС скорость {c1.maxSpeed}   Текущая скорсоть {c1.Speed}");

            c1.Speed = 90;
            Console.WriteLine($"{c1.maxSpeed}   {c1.Speed}");

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

    class MashineOne : Car
    {


        public override int Speed
        {

            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed + 2;
                }

            }
        }


    }

    class MashineTwo : Car
    {
    }
}
