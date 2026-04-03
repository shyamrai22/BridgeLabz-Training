using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class UnitConvertorThree
    {
        // Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fah)
        {
            double celsiusFah = (fah - 32) * 5 / 9;
            return celsiusFah;
        }

        // Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double cel)
        {
            double fahrenheitCel = (cel * 9 / 5) + 32;
            return fahrenheitCel;
        }

        // Pounds to Kilograms
        public static double PoundsToKilograms(double pounds)
        {
            double kgPounds = 0.453592;
            return pounds * kgPounds;
        }

        // Kilograms to Pounds
        public static double KilogramsToPounds(double kgs)
        {
            double poundKgs = 2.20462;
            return kgs * poundKgs;
        }

        // Gallons to Liters
        public static double GallonsToLiters(double gallons)
        {
            double ltGallons = 3.78541;
            return gallons * ltGallons;
        }

        // Liters to Gallons
        public static double LitersToGallons(double lts)
        {
            double gallonLt = 0.264172;
            return lts * gallonLt;
        }

        // Calling the methods
        public static void Caller()
        {
            Console.Write("Enter Fahrenheit: ");
            double fah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Fahrenheit to Celsius: {FahrenheitToCelsius(fah)}");

            Console.Write("Enter Celsius: ");
            double cel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Celsius to Fahrenheit: {CelsiusToFahrenheit(cel)}");

            Console.Write("Enter Pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Pounds to Kilograms: {PoundsToKilograms(pounds)}");

            Console.Write("Enter Kilograms: ");
            double kgs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kilograms to Pounds: {KilogramsToPounds(kgs)}");

            Console.Write("Enter Gallons: ");
            double gallons = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Gallons to Liters: {GallonsToLiters(gallons)}");

            Console.Write("Enter Liters: ");
            double lts = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Liters to Gallons: {LitersToGallons(lts)}");
        }
    }
}
