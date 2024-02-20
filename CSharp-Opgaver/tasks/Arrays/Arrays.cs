using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Arrays
{
    internal class Arrays_Tasks
    {
        public void Task1()
        {
            int sum = 0;

            int[] talArray = { -2, -1, 0, 10 };
            int[] talArrayTo = new int[4] { -2, -1, 0, 10 };

            for (int i = 0; i < talArray.Length; i++)
            {
                sum =+ talArray[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine(talArrayTo[2]);
            Console.WriteLine(talArrayTo[4]);
        }
    }
}
