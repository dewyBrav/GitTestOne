using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    abstract partial class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

        protected Employee.BenefitPackage  empBenifits = new BenefitPackage();


        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
        }
        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay) 
        {
            empSSN = ssn;
        }



        public class BenefitPackage   //класс, который моделирует пакет льгот для сотрудников, вложенный класс (в составе другво класса)
        {

            public enum BenefitPackageLevel
            {

                Standard, Gold, Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }


    }
}
