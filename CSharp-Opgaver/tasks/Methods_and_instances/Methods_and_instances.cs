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
            Bog SherlockHolmes = new Bog();
            Console.WriteLine("indtast dit budget");
            int budget = Convert.ToInt32(Console.ReadLine());
            if(SherlockHolmes.HarRåd(150, budget))
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
        public string PrintInfo()
        {
            return "Jeg er en bog";
        }

        public bool HarRåd(int pris, int budget)
        {
            if (pris <= budget)
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
