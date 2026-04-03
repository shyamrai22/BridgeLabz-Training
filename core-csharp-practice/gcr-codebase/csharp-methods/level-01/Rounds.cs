using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class Rounds
    {
        // Number of rounds
        public static double Calculations(double s1, double s2, double s3)
        {
            double per = s1 + s2 + s3;
            double totalDis = 5000; 
            return totalDis / per;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter side 1: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double s3 = Convert.ToDouble(Console.ReadLine());

            double r = Calculations(s1, s2, s3);

            Console.WriteLine(r);
        }
    }
}
