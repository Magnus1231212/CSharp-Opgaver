using CSharp_Opgaver.tasks.Methods_and_instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp_Opgaver.tasks.Inheritance
{
    internal class Inheritance
    {
        public void Task1()
        {
            Furniture furniture = new Furniture("Test 1");
            Chair chair = new Chair("Test 2");
            Computer computer = new Computer("Test 3");

            furniture.print();
            chair.print();
            computer.print();
        }
    }

    public class Furniture
    {
        private string Name { get; set; }

        public Furniture(string tekst)
        {
            Name = tekst;
        }

        public void print()
        {
            Console.WriteLine(Name);
        }
    }

    public class Chair : Furniture
    {
        private string Name {  set; get; }

        public Chair(string tekst) : base(tekst)
        {
            Console.WriteLine(tekst);
        }

        public void print()
        {
            Console.WriteLine(Name);
        }
    }

    public class Computer : Furniture
    {
        private string Name { set; get; }

        public Computer(string tekst) : base(tekst)
        {
            Console.WriteLine(tekst);
        }

        public void print()
        {
            Console.WriteLine(Name);
        }
    }
}
