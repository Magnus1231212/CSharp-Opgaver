using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver
{
    internal class Menu
    {
        public static void build(string Menu, string[] Options, Action[] Cases)
        {
            int choice = -1;
            do
            {
                Console.Title = $"C# Opgaver - {Menu}";

                Console.Clear();

                Console.WriteLine($"Menu: {Menu} \nChoose what task you want to run?:\n");

                foreach (string Option in Options)
                {
                    Console.WriteLine(Option);
                }

                Console.WriteLine("\n\t0. Go Back");

                Console.Write("\n\tChoice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                }

                if(choice >= 1 && choice <= Options.Length)
                {
                    try {
                        Cases[choice - 1]();
                    } catch (Exception e)
                    {
                        Debug.WriteLine(e);
                    }
                }
                else if (choice == 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (choice != 0);
        }
    }
}
