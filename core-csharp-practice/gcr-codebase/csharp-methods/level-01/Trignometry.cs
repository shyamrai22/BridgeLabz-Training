using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class Trigonometry
    {
        // Sin, Cos, Tan
        public static double[] CalculateTrigonometricFunctions(double a)
        {
 
            double rad = a * Math.PI / 180;

            double s = Math.Sin(rad);
            double c = Math.Cos(rad);
            double t = Math.Tan(rad);

            return new double[] { s, c, t };
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter angle (degrees): ");
            double a = Convert.ToDouble(Console.ReadLine());
            double[] res = CalculateTrigonometricFunctions(a);

            Console.WriteLine($"Sin : {res[0]}");
            Console.WriteLine($"Cos : {res[1]}");
            Console.WriteLine($"Tan : {res[2]}");
        }
    }
}
