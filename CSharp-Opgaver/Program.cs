using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            do
            {
                string[] options = {
                    "1. Variables",
                    "2. Strings",
                    "3. Arithmetic expressions",
                    "4. Variable expressions",
                    "5. Boolean variables",
                    "6. if-else statements",
                    "7. Switch Case",
                    "8. Loops",
                    "9. Extended control structures",
                    "10. Methods and instances",
                    "11. Return types and parameters",
                    "12. Instance variables",
                    "13. Inheritance",
                    "14. Constructors",
                    "15. Arrays",
                    "16. Traversing arrays"
                };

                Action[] cases = {
                    () => SubMenus.Variables(),
                    () => SubMenus.Strings(),
                    () => SubMenus.Arithmetic_expressions(),
                    () => SubMenus.Variable_expressions(),
                    () => SubMenus.Boolean_variables(),
                    () => SubMenus.if_else_statements(),
                    () => SubMenus.Switch_Case(),
                    () => SubMenus.Loops(),
                    () => SubMenus.Extended_control_structures(),
                    () => SubMenus.Methods_and_instances(),
                    () => SubMenus.Return_types_and_parameters(),
                    () => SubMenus.Instance_variables(),
                    () => SubMenus.Inheritance(),
                    () => SubMenus.Constructors(),
                    () => SubMenus.Arrays(),
                    () => SubMenus.Traversing_arrays() 
                };

                Menu.buildMain(options, cases);

            }while (!Exit);
        }
    }
}
