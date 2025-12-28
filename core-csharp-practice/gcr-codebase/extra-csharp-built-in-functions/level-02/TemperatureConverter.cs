using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class TemperatureConverter
    {
        public static void Caller()
        {
            Console.WriteLine("1. Cel to Fah");
            Console.WriteLine("2. Fah to Cel");

            int c = Input("Enter choice 1 or 2: ");

            if (c == 1)
            {
                double cel = InputDouble("Enter temperature in cel: ");
                double fah = CelToFah(cel);
                Display(cel, fah, true);
            }
            else if (c == 2)
            {
                double fah = InputDouble("Enter temperature in fah: ");
                double cel = FahToCel(fah);
                Display(cel, fah, false);
            }
            else
                Console.WriteLine("Invalid choice");
            
        }

        static int Input(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        static double InputDouble(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }

        static double CelToFah(double c)
        {
            return (c * 9 / 5) + 32;
        }

        static double FahToCel(double f)
        {
            return (f - 32) * 5 / 9;
        }

        // Output
        static void Display(double c, double f, bool fromCel)
        {
            if (fromCel)
                Console.WriteLine($"{c} °C = {f} °F");
            else
                Console.WriteLine($"{f} °F = {c} °C");
        }
    }
}
