using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Loops
{
    internal class Loops_Tasks
    {
        public void Task1()
        {
            int i = 1;

            Console.WriteLine("While-loop:");
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine();

            Console.WriteLine("For-loop:");
            for (int l = 1; l <= 10; l++)
            {
                Console.WriteLine(l);
            }
        }

        public void Task2()
        {
            int i = 100;

            Console.WriteLine("While-loop:");
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine();

            Console.WriteLine("For-loop:");
            for (int l = 100; l >= 1; l--)
            {
                Console.WriteLine(l);
            }
        }

        public void Task3()
        {
            Console.WriteLine("5 Tabellen");

            int i = 5;

            while (i <= 50)
            {
                Console.WriteLine(i);
                i += 5;
            }
        }

        public void Task4()
        {
            int i = 20;

            Console.WriteLine("While-loop:");
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine();

            Console.WriteLine("For-loop:");
            for (int l = 20; l >= 0; l--)
            {
                Console.WriteLine(l);
            }
        }

        public void Task5()
        {
            Console.WriteLine("7 Tabellen");
            for (int l = 1; l <= 10; l++)
            {
                Console.WriteLine($"{l,2} * 7 = {l * 7,2}");
            }
        }

        public void Task6()
        {
            Console.WriteLine("Indtast en Tabel");
            int tabel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{tabel} Tabellen");
            for (int l = 1; l <= 10; l++)
            {
                Console.WriteLine($"{l,3} * {tabel} = {l * tabel,3}");
            }
        }

        public void Task7()
        {

        }

        public void Task8()
        {

        }

        public void Task9()
        {

        }
    }
}
