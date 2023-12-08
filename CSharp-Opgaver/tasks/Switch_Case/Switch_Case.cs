using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Switch_Case
{
    internal class Switch_Case_Tasks
    {
        public void Task1()
        {
            Console.WriteLine("Indtast et tal mellem 1-6");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Du har tastet {choice}");
                    break;
                case 2:
                    Console.WriteLine($"Du har tastet {choice}");
                    break;
                case 3:
                    Console.WriteLine($"Du har tastet {choice}");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition((Console.WindowWidth - "TILLYKKE DU HAR VUNDET".Length) / 2, Console.WindowHeight / 2);
                    Console.WriteLine("TILLYKKE DU HAR VUNDET");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.WriteLine($"Du har tastet {choice}");
                    break;
                case 6:
                    Console.WriteLine($"Du har tastet {choice}");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
        }

        public void Task2()
        {
            Console.WriteLine("Vælge en drink!\n");

            Console.WriteLine("1.Isbjørn");
            Console.WriteLine("2.Champagnebrus");
            Console.WriteLine("3.Tequila Sunrise");
            Console.WriteLine("4.Mojito");
            Console.WriteLine("5.Brandbil");
            Console.WriteLine("6.Filur");

            Console.WriteLine("\nValg: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Du har valgt en Isbjørn");
                    Console.WriteLine("Pris: 32 Kr.");
                    break;
                case 2:
                    Console.WriteLine("Du har valgt en Champagnebrus");
                    Console.WriteLine("Pris: 52 Kr.");
                    break;
                case 3:
                    Console.WriteLine("Du har valgt en Tequila Sunrise");
                    Console.WriteLine("Pris: 42 Kr.");
                    break;
                case 4:
                    Console.WriteLine("Du har valgt en Mojito");
                    Console.WriteLine("Pris: 62 Kr.");
                    break;
                case 5:
                    Console.WriteLine("Du har valgt en Brandbil");
                    Console.WriteLine("Pris: 72 Kr.");
                    break;
                case 6:
                    Console.WriteLine("Du har valgt en Filur");
                    Console.WriteLine("Pris: 82 Kr.");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
        }
    }
}
