using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Opgaver.tasks.Return_types_and_parameters
{
    internal class Return_types_and_parameters
    {
        public void Task1()
        {
            Bil bil = new Bil();
            Console.WriteLine(bil.StartBil());
            Console.WriteLine(bil.StopBil());
        }

        public void Task2()
        {
            Bil bil = new Bil();
            Console.WriteLine(bil.FillGasOne(2.5));
        }

        public void Task3()
        {
            Bil bil = new Bil();
            Console.WriteLine("Hvor mange liter vil du fylde på?");
            double liters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Er det diesel? (true/false)");
            bool isDiesel = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(bil.FillGasTwo(liters, isDiesel));
        }

        public void Task4()
        {
            Bil bil = new Bil();
            Console.WriteLine("Hvor mange liter er der tilbage i tanken?");
            double rGas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(bil.RemainingGas(rGas));
        }
    }

    public class Bil
    {
        public string StartBil()
        {
            return "Motoren er startet";
        }

        public string StopBil()
        {
            return "Motoren er slukket";
        }

        public string FillGasOne(double liters)
        {
            return "Filled tank with: " + liters + " liters";
        }

        public string FillGasTwo(double liters, bool isDiesel)
        {
            string type = isDiesel ? "Diesel" : "Benzin";
            return "Filled tank with: " + liters + " liters of " + type;
        }

        public double RemainingGas(double rGas)
        {
            double RemainingGas = rGas;
            return RemainingGas;
        }
    }
}
