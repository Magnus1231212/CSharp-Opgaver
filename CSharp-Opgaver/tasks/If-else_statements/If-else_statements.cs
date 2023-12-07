using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            string name = "Karl";
            string brugernavn = "Karl123";
            string password = "123";

            Console.WriteLine("Indtast dit brugernavn!");
            string UserN = Console.ReadLine();

            if(UserN == brugernavn)
            {
                Console.WriteLine("Indtast dit password!");
                string UserP = Console.ReadLine();

                if(UserP == password)
                {
                    Console.WriteLine($"Velkommen {name}");
                } else
                {
                    Console.WriteLine("Password er forkert!");
                }
            } else
            {
                Console.WriteLine("Brugernavn er forkert!");
            }

        }

        public void Task6()
        {
            Console.WriteLine("Hvor mange km køre du hver dag til og fra arbejde?");
            int km = Convert.ToInt32(Console.ReadLine());

            if (km < 24)
            {
                Console.WriteLine("Du får ikke noget fradrag.");
            } else if (km > 25 && km < 120)
            {
                Console.WriteLine($"Du får {(km - 24) * 1,93}Kr i fradrag.");
            } else if (km > 121)
            {
                Console.WriteLine($"Du får {(km - 120) * 0,97}Kr i fradrag.");
            }
        }

        public void Task7()
        {
            Console.Title = "Festen";

            Console.Write("Hvilken farve foretrækker du: rød, grøn, blå eller gul? ");
            string yndlingsfarve = Console.ReadLine();

            Console.Write("Hvor gammel er du? ");
            string alderStr = Console.ReadLine();
            int alder = Convert.ToInt32(alderStr);

            Console.WriteLine($"Baggrundsfarven sættes til {yndlingsfarve} efterfulgt af Clear.");

            if (alder > 18)
            {
                Console.WriteLine("Velkommen til cocktailbaren!");
            }
            else
            {
                Console.WriteLine("Velkommen til sodavandsbaren.");
            }

            Thread.Sleep(10000);
            Console.WriteLine("Programmet lukker nu.");
        }
    }
}
