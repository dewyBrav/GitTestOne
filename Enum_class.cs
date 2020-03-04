using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestOne
{
    class Enum_class
    {
        enum EmpType: byte
        {
            Manager=1,
            Grunt,
            Contracter,
            VicePresident

        }


        public static void CallMethod()
        {

            Enum_class MT = new Enum_class();
            Console.WriteLine("\nВызов из класса: {0}", MT.NAmeCall);

            EmpType emp = EmpType.Contracter;
            Console.WriteLine("Значение: {0} - {1}   тип: {2}", emp.ToString(), (byte)emp, Enum.GetUnderlyingType(emp.GetType()));


            Array enumData = Enum.GetValues(emp.GetType());
           for(int i =0; i<enumData.Length; i++)
            {
                Console.Write("{0} ",enumData.GetValue(i) );
            }

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
