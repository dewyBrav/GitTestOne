using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    partial class Employee
    {

        /*private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSSN;
        */


            public double GetBenefitCost()
        {
            return empBenifits.ComputePayDeduction();
        }
        public BenefitPackage Benefits
        {
            get { return empBenifits; }
            set { empBenifits = value; }

        }


        public string SocialSecNumber
        {
            get { return empSSN; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15) Console.WriteLine("Error! Name lenght exceeds 15 characters!");
                else empName = value;
            }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

   
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("SSN: {0}", SocialSecNumber);
        }



    }
}
