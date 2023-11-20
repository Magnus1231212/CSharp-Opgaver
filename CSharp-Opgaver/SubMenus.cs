using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Opgaver
{
    internal class SubMenus
    {
        public static void Variables()
        {
            int choice = -1;
            do {
                string[] options = { 
                    "\t1. Task 1 \t Desc: ", 
                    "\t2. Task 2 \t Desc: ", 
                    "\t3. Task 3 \t Desc: ", 
                    "\t4. Task 4 \t Desc: ", 
                    "\t5. Task 5 \t Desc: "
                };
                Menu.build("Variables", options);

                if (!int.TryParse(Console.ReadLine(), out choice)) 
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 0:
                        {
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
            } while (choice != 0);
        }

        public static void Strings()
        {

        }

        public static void Menu3()
        {

        }
        
        public static void Menu4()
        {

        }

        public static void Menu5()
        {

        }

        public static void Menu6()
        {

        }

        public static void Menu7()
        {

        }
    }
}
