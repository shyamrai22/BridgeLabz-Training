using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class Si
    {
        // Simple Interest
        public static double SiCalculations(double p, double r, double t)
        {
            return (p * r * t) / 100;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter Principal: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time: ");
            double t = Convert.ToDouble(Console.ReadLine());

            double si = SiCalculations(p, r, t);

            Console.WriteLine($"The Simple Interest is {si}");
        }

    }
}
