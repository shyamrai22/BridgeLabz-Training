using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Euclidean
    {
        // Euclidean distance
        public static double EucDistance(double x1, double y1, double x2, double y2)
        {

            double dx = x2 - x1;
            double dy = y2 - y1;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        
        }

        // Slope and y-intercept
        public static double[] LineEqs(double x1, double y1, double x2, double y2)
        {

            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;

            return new double[] { m, b };

        }

        // Calling above methods
        public static void Caller()
        {

            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double dist = EucDistance(x1, y1, x2, y2);
            double[] line = LineEqs(x1, y1, x2, y2);

            Console.WriteLine($"Euclidean Distance: {Math.Round(dist, 2)}");
            Console.WriteLine($"Equation of Line: y = {Math.Round(line[0], 2)}x + {Math.Round(line[1], 2)}");

        }
    }
}
