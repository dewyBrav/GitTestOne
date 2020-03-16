using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace GitTestOne
{
    partial class MyCollection<T>
    {

        public static void SimpleBoxUnboxOperation()
        {
            ArrayList bigData = new ArrayList();

            for(int i=0; i<10000000; i++)
            {

                bigData.Add(i);

            }


        }

        public static void TOperation()
        {
            List<int> bigData = new List<int>();

            for (int i = 0; i < 10000000; i++)
            {

                bigData.Add(i);

            }


        }

    }


}
