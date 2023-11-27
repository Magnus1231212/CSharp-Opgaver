using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Strings
{
    internal class Strings_Tasks
    {
        public void Task1()
        {
            int var1 = 54;
            string var2 = "Hej";
            double var3 = 5.34;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
        }
        public void Task2()
        {
            int var1 = 54;
            string var2 = "Hej";
            double var3 = 5.34;

            Console.WriteLine("Indtast venligst et heltal");
            var1 = int.Parse(Console.ReadLine());

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);

        }

        public void Task3()
        {
            Console.WriteLine("Task 3");
            Console.ReadKey();
        }

        public void Task4()
        {
            Console.WriteLine("Task 4");
            Console.ReadKey();
        }
    }
}
