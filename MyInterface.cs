using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class MyInterface
    { 

        public static void MyInterfaceI()
        {
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();

            MyInterface MT = new MyInterface();
            Console.WriteLine("\n\nВызов из класса: {0}", MT.Names);

            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);

            
            string uu = "1111";
            string u = uu.Clone() + "0";
            Console.WriteLine(u);
        }

        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
        }


        string Names
        {

            get
            {
                return GetType().Name;
            }
        }
    }
}



