﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Strings
{
    internal class Strings_Tasks
    {
        // Opgave 1
        public void Task1()
        {
            int var1 = 54;
            string var2 = "Hej";
            double var3 = 5.34;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
        }

        // Opgave 2
        public void Task2()
        {
            int var1 = 54;
            string var2 = "Hej";
            double var3 = 5.34;

            Console.WriteLine("Indtast venligst et heltal");
            var1 = int.Parse(Console.ReadLine());

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);

        }

        // Opgave 3
        public void Task3()
        {
            string udskrivning = "I dag har vi den 24. December";
            Console.WriteLine(udskrivning);
        }


        // Opgave 4
        public void Task4()
        {
            double number = 200.50;
            string first = "Jeg har";
            string last = "kr. i banken.";
            Console.WriteLine($"{first} {number}{last}");
        }
    }
}
