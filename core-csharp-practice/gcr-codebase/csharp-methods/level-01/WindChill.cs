using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class WindChill
    {

        // Wind chill temperature

        public static double Calculate(double temp, double wSpeed)
        {
            double wChill = 35.74
                               + (0.6215 * temp)
                               + ((0.4275 * temp - 35.75) * Math.Pow(wSpeed, 0.16));

            return wChill;
        }


        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter wind speed: ");
            double wSpeed = Convert.ToDouble(Console.ReadLine());
            double res = Calculate(temp, wSpeed);

            Console.WriteLine($"Wind chill temperature : {res}");
        }
    }
}
