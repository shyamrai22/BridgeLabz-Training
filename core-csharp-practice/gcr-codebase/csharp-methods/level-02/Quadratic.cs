using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class Quadratic
    {
        // Finding roots of quadratic equation
        public static double[] Roots(double a, double b, double c)
        {
            
            double del = Math.Pow(b, 2) - 4 * a * c;

            if (del < 0)
            {
                return new double[0];
            }

            if (del == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }

            double sqrtDel = Math.Sqrt(del);
            double r1 = (-b + sqrtDel) / (2 * a);
            double r2 = (-b - sqrtDel) / (2 * a);

            return new double[] { r1, r2 };

        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());


            double[] roots = Roots(a, b, c);


            if (roots.Length == 0)
            {
                Console.WriteLine("No real roots");
            }

            else if (roots.Length == 1)
            {
                Console.WriteLine($"One root: {Math.Round(roots[0], 2)}");
            }

            else
            {
                Console.WriteLine($"Root 1 : {Math.Round(roots[0], 2)}");
                Console.WriteLine($"Root 2 : {Math.Round(roots[1], 2)}");
            }

        }
    }
}
