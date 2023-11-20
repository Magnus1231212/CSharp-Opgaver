using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver
{
    internal class Menu
    {
        public static void build(string Menu, string[] Options)
        {
            Console.Clear();

            Console.WriteLine($"Menu: {Menu} \nChoose what task you want to run?:\n");

            foreach (string Option in Options)
            {
                Console.WriteLine(Option);
            }

            Console.WriteLine("\n\t0. Go Back");

            Console.Write("\n\tChoice: ");
        }
    }
}
