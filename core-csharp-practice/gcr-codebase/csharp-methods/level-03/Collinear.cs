using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Collinear
    {
        
        public static bool BySlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double sAB = (y2 - y1) / (x2 - x1);
            double sBC = (y3 - y2) / (x3 - x2);
            double sAC = (y3 - y1) / (x3 - x1);

            return sAB == sBC && sBC == sAC;
        }

        
        public static bool ByArea( double x1, double y1, double x2, double y2, double x3, double y3)
        {

            double a = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            return a == 0;
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

            Console.Write("Enter x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y3: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            bool slopeRes = BySlope(x1, y1, x2, y2, x3, y3);
            bool areaRes = ByArea(x1, y1, x2, y2, x3, y3);

            Console.WriteLine($"Using Slope Method: {slopeRes}");
            Console.WriteLine($"Using Area Method : {areaRes}");
        }
    }
}
