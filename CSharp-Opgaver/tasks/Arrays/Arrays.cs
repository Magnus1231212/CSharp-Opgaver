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
                sum += talArray[i];
            }
            Console.WriteLine(sum);

            Console.WriteLine(talArrayTo[1]);
            Console.WriteLine(talArrayTo[3]);
        }

        public void Task2()
        {
            int sum = 0;

            int[] talArray = { 1, 2, 3, 4, 5, 6 };
            string[] stringArray = { "Hej", "med", "dig", "du", "der" };

            for (int i = 0; i < talArray.Length; i++)
            {
                sum += talArray[i];
            }

            Console.WriteLine(sum);

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}
