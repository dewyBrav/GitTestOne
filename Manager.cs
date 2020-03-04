using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Manager:Employee
    {
        public int StockOption { get; set; }

        public Manager() { }
        public Manager(string fullName, int age, int empID, float cuurPay, string ssn, int numbOfOpts):base(fullName, age,empID, cuurPay, ssn)
        {
            StockOption = numbOfOpts;


        }


        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOption += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOption);
        }
    }



    
}
