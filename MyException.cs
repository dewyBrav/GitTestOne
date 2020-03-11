using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class MyException
    {
        public static void CallMethod()
        {

            try
            {

                MyException MT = new MyException();
                Console.WriteLine("\nВызов из класса: {0}", MT.NAmeCall);

                object i = "1";
                int o = (int)i;//исключение
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} \n {ex.Data}\n {ex.Source}\n {ex.StackTrace}\n {ex.TargetSite}\n {ex.HResult}\n {ex.HelpLink}");
            }


        }

        public MyException()
        {


        }

        public MyException(string s):base()
        {


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

