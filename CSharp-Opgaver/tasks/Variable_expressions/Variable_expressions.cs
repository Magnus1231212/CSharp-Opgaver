using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Variable_expressions
{
    internal class Variable_expressions_Tasks
    {
        public void Task1()
        {
            int a = 5;
            int b = 10;
            int c = 15;
            int result = a + b * c;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine(result);
        }

        public void Task2()
        {
            int a = 10;
            double b = 3.5;
            int kim = 7;
            double result;

            result = a + b + kim;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"kim: {kim}");
            Console.WriteLine($"result: {result}");
        }
    }
}
