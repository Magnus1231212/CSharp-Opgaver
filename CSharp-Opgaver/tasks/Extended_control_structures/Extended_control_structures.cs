using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Extended_control_structures
{
    internal class Extended_control_structures_Tasks
    {
        public void Task1()
        {
            for (int l = 1; l <= 10; l++)
            {
                int number = l * 7;

                Console.WriteLine(number);

                if (number == 21)
                {
                    Console.WriteLine("Loopen er nu stoppet.");
                    break;
                }
            }
        }

        public void Task2()
        {
            int number = 0;

            while (number <= 10)
            {
                if(number * 4 != 16)
                {
                    Console.WriteLine(number * 4);
                }

                number++;
            }
            Console.WriteLine("Loopen er nu stoppet.");
        }

        public void Task3()
        {
            Console.WriteLine("Indtast Km");
            int km = Convert.ToInt32(Console.ReadLine());
            if(km <= 24)
            {
                Console.WriteLine("Du kan ikke få et fradrag");
            } else if(km >= 25 && km <= 100)
            {
                Console.WriteLine("Du kan få et fradrag på 1,93 kr. pr. km");
            } else if (km > 100) 
            {
                Console.WriteLine("Du kan få et fradrag på 0,77 kr. pr. km");
            }
        }

        public void Task4()
        {
            Console.WriteLine("Task 4");
        }

        public void Task5()
        {
            Console.WriteLine("Task 5");
        }
    }
}
