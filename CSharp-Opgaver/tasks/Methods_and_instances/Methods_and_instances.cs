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
            Bog SherlockHolmes = new Bog(0, "");
            Console.WriteLine(SherlockHolmes.PrintInfo());
        }

        public void Task2()
        {
            Bog SherlockHolmes = new Bog(150, "SherlockHolmes");
            Console.WriteLine("indtast dit budget");
            int budget = Convert.ToInt32(Console.ReadLine());
            if(SherlockHolmes.HarRåd(budget))
            {
                Console.WriteLine("Du har råd til bogen");
            } else
            {
                Console.WriteLine("Du har ikke råd til bogen");
            }
        }
    }

    public class Bog
    {
        public int Pris { get; set; }
        public string Titel { get; set; }
        
        public Bog(int pris, string titel)
        {
            Pris = pris;
            Titel = titel;
            Console.WriteLine($"{Titel} - koster {Pris} kr");
        }

        public string PrintInfo()
        {
            return "Jeg er en bog";
        }

        public bool HarRåd(int budget)
        {
            if (Pris <= budget)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
