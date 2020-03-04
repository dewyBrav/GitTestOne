using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }

        public SalesPerson(string fullName, int age, int empID, float cuurPay, string ssn, int numbOFSales) : base(fullName, age, empID, cuurPay, ssn)
        {

            SalesNumber = numbOFSales;
        }

        public override void GiveBonus(float amount)
        {

            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100) salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200) salesBonus = 15;
                else salesBonus = 20;

            }
            base.GiveBonus(amount * salesBonus);
           
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("SalesNumber: {0}", SalesNumber);
        }
    }
}
