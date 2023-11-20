using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver
{
    internal class Program
    {
        public static bool Exit = false;

        static void Main(string[] args)
        {
            Console.Title = "C# Opgaver";
            do
            {
                Menu();

            }while (!Exit);
        }

        static void Menu()
        {
            int subMenu = -1;

            Console.Clear();

            Console.WriteLine("Choose what task you want to run?: \n");

            Console.WriteLine("\t1. Variables");
            Console.WriteLine("\t2. Strings");
            Console.WriteLine("\t3. Arithmetic Expressions");
            Console.WriteLine("\t4. Variable expressions");
            Console.WriteLine("\t5. Boolean variables");
            Console.WriteLine("\t6. if-else statements");
            Console.WriteLine("\t7. Switch Case");
            Console.WriteLine("\t8. Loops");
            Console.WriteLine("\t9. Advanced control structures");
            Console.WriteLine("\t10. Methods and instances");
            Console.WriteLine("\t11. Return types and parameters");
            Console.WriteLine("\t12. Instance variables");
            Console.WriteLine("\t13. Inheritance");
            Console.WriteLine("\t14. Constructors");
            Console.WriteLine("\t15. Arrays");
            Console.WriteLine("\t16. Traversing arrays");
            Console.WriteLine("\n\t0. Exit");

            Console.Write("\n\tChoice: ");

            try
            {
                subMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(subMenu);
            }
            catch
            {

            }

            SubMenu(subMenu);
        }

        static void SubMenu(int Case)
        {
            switch (Case)
            {
                case 1:
                    {
                        SubMenus.Variables();
                        break;
                    }
                case 2:
                    {
                        SubMenus.Strings();
                        break;
                    }
                case 3:
                    {
                        SubMenus.Menu3();
                        break;
                    }
                case 4:
                    {
                        SubMenus.Menu4();
                        break;
                    }
                case 5:
                    {
                        SubMenus.Menu5();
                        break;
                    }
                case 6:
                    {
                        SubMenus.Menu6();
                        break;
                    }
                case 7:
                    {
                        SubMenus.Menu7();
                        break;
                    }

                case 0:
                    {
                        Exit = true;
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    }
            }
        }
    }
}
