﻿using System;
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
            int startX = 20;
            int startY = 4;
            int endX = 30;
            int endY = 8;

            for (int x = startX; x <= endX; x++)
            {
                Console.SetCursorPosition(x, startY);
                Console.Write("*");
            }

            for (int y = startY + 1; y <= endY; y++)
            {
                Console.SetCursorPosition(endX, y);
                Console.Write("*");
            }

            for (int x = endX - 1; x >= startX; x--)
            {
                Console.SetCursorPosition(x, endY);
                Console.Write("*");
            }

            for (int y = endY - 1; y > startY; y--)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write("*");
            }
        }

        public void Task8()
        {
            int startX = 20;
            int startY = 4;
            int endX = 30;
            int endY = 8;

            for (int x = startX; x <= endX; x++)
            {
                Console.SetCursorPosition(x, startY);
                Console.Write("*");
            }

            for (int y = startY + 1; y <= endY; y++)
            {
                Console.SetCursorPosition(endX, y);
                Console.Write("*");
            }

            for (int x = endX - 1; x >= startX; x--)
            {
                Console.SetCursorPosition(x, endY);
                Console.Write("*");
            }

            for (int y = endY - 1; y > startY; y--)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write("*");
            }

            Console.SetCursorPosition(startX + 2, endY - 2);
            Console.Write("Magnus");
        }

        public void Task9()
        {
            int startX = 20;
            int startY = 4;
            string symbol = "*";

            Console.WriteLine("Indtast brede");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast højde");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("indtast Navn");
            string Name = Console.ReadLine();
            int NameLenght = Name.Length;

            Console.Clear();

            for (int x = startX; x < startX + width; x++)
            {
                Console.SetCursorPosition(x, startY);
                Console.Write(symbol);
            }

            for (int y = startY + 1; y < startY + height; y++)
            {
                Console.SetCursorPosition(startX + width - 1, y);
                Console.Write(symbol);
            }

            for (int x = startX + width - 2; x >= startX; x--)
            {
                Console.SetCursorPosition(x, startY + height - 1);
                Console.Write(symbol);
            }

            for (int y = startY + height - 2; y > startY; y--)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write(symbol);
            }

            Console.SetCursorPosition(startX + 2, startY + 2);
            Console.Write(Name);
        }
    }
}
