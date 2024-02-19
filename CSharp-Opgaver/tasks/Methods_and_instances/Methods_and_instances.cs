using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Methods_and_instances
{
    internal class Methods_and_instances_Tasks
    {
        public void Task1()
        {
            Bog SherlockHolmes = new Bog();
            Console.WriteLine(SherlockHolmes.PrintInfo());
        }

        public void Task2()
        {
            Console.WriteLine("Task 2");
        }
    }

    public class Bog
    {
        public string PrintInfo()
        {
            return "Jeg er en bog";
        }
    }
}
