using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.If_else_statements
{
    internal class If_else_statements_Tasks
    {
        public void Task1()
        {
            int tal1 = 42;
            int tal2 = 64;
            int result = tal1 + tal2;

            if (result > 100)
            {
                Console.WriteLine("Summen er større end 100!.");
            }
            else if (result < 100)
            {
                Console.WriteLine("Summen er mindre end 100");
            }
            else
            {
                Console.WriteLine("Summen er 100");
            }
        }

        public void Task2()
        {
            Console.WriteLine("Indtast en alder!");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age > 57)
            {
                Console.WriteLine("Du er for gammel!");
            } else if(age <= 57)
            {
                Console.WriteLine("Du er ikke for gammel!");
            }
        }

        public void Task3()
        {
            Console.WriteLine("Indtast en alder!");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 60)
            {
                Console.WriteLine("Du for gammel!");
            }
            else if (age > 50 && age < 60)
            {
                Console.WriteLine("Du er hverken for gammel eller for ung!");
            } else if(age < 50)
            {
                Console.WriteLine("Du er for ung!");
            }
        }

        public void Task4()
        {
            string name = "Karl";
            string brugernavn = "Karl123";
            string password = "123";

            Console.WriteLine("Indtast dit brugernavn!");
            string UserN = Console.ReadLine();

            Console.WriteLine("Indtast dit password!");
            string UserP = Console.ReadLine();
            
            if(UserN == brugernavn && UserP == password)
            {
                Console.WriteLine($"Velkommen {name}");
            } else
            {
                Console.WriteLine("brugernavn eller password er forkert.");
            }
        }

        public void Task5()
        {
            Console.WriteLine("Task 5");
            Console.ReadKey();
        }

        public void Task6()
        {
            Console.WriteLine("Task 6");
            Console.ReadKey();
        }
    }
}
