using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Menu(0);

            }while (true);
        }

        static void Menu(int type)
        {
            switch(type)
            {
                case 0:
                    {
                        Console.WriteLine("1. Opgave 1");
                        return;
                    }
                case 1:
                    {
                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }
    }
}
