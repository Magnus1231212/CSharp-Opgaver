using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Variables
{
    internal class Variables_Tasks
    {
        // Opgave 1
        public void Task1()
        {
            int tal1 = 5;
            int tal2 = 3;
            Console.WriteLine(tal1);
            Console.WriteLine(tal2);
        }

        // Opgave 2
        public void Task2()
        {
            int tal1 = 5;
            int tal2 = 3;
            Console.WriteLine($"Tal1 er {tal1}");
            Console.WriteLine($"Tal2 er {tal2}");
        }

        // Opgave 3
        public void Task3()
        {
            string Navn = "Søren";
            int Alder = 16;
            double Penge = 1234.34;
            Console.WriteLine($"Jeg hedder {Navn}, er {Alder} år gammel og har tjent {Penge} kr. på at lappe cykler");
        }

        // Opgave 4
        public void Task4()
        {
            double Kage = 23.56;
            double Øl = 34.67;
            double Pølse = 65.34;
            Console.WriteLine($"Kage\t {Kage}");
            Console.WriteLine($"Øl\t {Øl}");
            Console.WriteLine($"Pølse\t {Pølse}");
            Console.WriteLine($"I alt\t {Kage + Øl + Pølse}");
        }

        // Opgave 5
        public void Task5()
        {
            Console.WriteLine("Indtast venligst dit navn");
            string Navn = Console.ReadLine();
            Console.WriteLine("Indtast venligst din alder");
            int Alder = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nJeg hedder {Navn} og er {Alder} år gammel.");
        }

        // Opgave 6
        public void Task6()
        {
            Console.WriteLine("Indtast venligst en radius");
            double Radius = double.Parse(Console.ReadLine());
            double PI = Math.PI;
            double R2 = Math.Pow(Radius, 2);
            Console.WriteLine($"\nAreal = {PI * R2}");
            Console.WriteLine($"Pi = {PI}");
            Console.WriteLine($"R2 = {R2}");
        }
    }
}
