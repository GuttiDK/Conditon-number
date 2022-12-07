using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{

    class Program
    {
        public static void Main()
        {
            Console.Write("Indtast din max puls i heltal slag i minuttet: ");
            Int16 maxpulse = Int16.Parse(Console.ReadLine());
            Console.Write("Indtast din hvilepuls i heltal slag i minuttet: ");
            Int16 restPulse = Int16.Parse(Console.ReadLine());
            Console.Write("Indtast din vægt (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dit kondital er: {0}", Condylarcount.CalculateCondital(maxpulse, restPulse));
            Console.WriteLine("Din maksimale iltindtagelse er: {0}", Condylarcount.CalculateOxygenIntake(maxpulse, restPulse, weight));
        }

    }

    class Condylarcount
    {
        public static double CalculateCondital(Int16 maxPulse, Int16 restPulse)
        {
            double intCondi = Math.Round((double)maxPulse / restPulse * 15.3);
            return intCondi;
        }

        public static double CalculateOxygenIntake(Int16 maxPulse, Int16 restPulse, double weight)
        {
            double intOxygenIntake = Math.Round((double)Condylarcount.CalculateCondital(maxPulse, restPulse) / weight * 1000);
            return intOxygenIntake;
        }

    }
}
