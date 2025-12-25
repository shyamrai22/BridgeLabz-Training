using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class UnitConvertorTwo
    {
        // Yards to feet
        public static double YardsToFeet(double yards)
        {
            double feetYards = 3;
            return yards * feetYards;
        }

        // Feet to yards
        public static double FeetToYards(double feet)
        {
            double yardsFeet = 0.333333;
            return feet * yardsFeet;
        }

        // Meters to inches
        public static double MetersToInches(double meters)
        {
            double inchesMeter = 39.3701;
            return meters * inchesMeter;
        }

        // Inches to meters
        public static double InchesToMeters(double inches)
        {
            double meterInches = 0.0254;
            return inches * meterInches;
        }

        // Convert inches to centimeters
        public static double InchesToCentimeters(double inches)
        {
            double cmInches = 2.54;
            return inches * cmInches;
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter yards: ");
            double yards = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Yards to Feet: {YardsToFeet(yards)}");


            Console.Write("Enter feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Feet to Yards: {FeetToYards(feet)}");

            
            Console.Write("Enter meters: ");
            double meters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Meters to Inches: {MetersToInches(meters)}");

            
            Console.Write("Enter inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Inches to Meters: {InchesToMeters(inches)}");
            Console.WriteLine($"Inches to Centimeters: {InchesToCentimeters(inches)}");
        }
    }
}
