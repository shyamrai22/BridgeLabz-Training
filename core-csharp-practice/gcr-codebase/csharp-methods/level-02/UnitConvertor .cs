using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class UnitConvertor
    {
        // Kilometers to miles
        public static double KmToMiles(double km)
        {
            double milesKm = 0.621371;
            return km * milesKm;
        }

        // Miles to kilometers
        public static double MilesToKm(double miles)
        {
            double kmMiles = 1.60934;
            return miles * kmMiles;
        }

        // Meters to feet
        public static double MetersToFeet(double meters)
        {
            double feetMeters = 3.28084;
            return meters * feetMeters;
        }

        // Feet to meters
        public static double FeetToMeters(double feet)
        {
            double metersFeet = 0.3048;
            return feet * metersFeet;
        }

        // Calling above methods
        public static void Caller()
        {

            Console.Write("Enter kms: ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kilometers to Miles: {KmToMiles(km)}");

            Console.Write("Enter miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Miles to Kilometers: {MilesToKm(miles)}");

            Console.Write("Enter meters: ");
            double meters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Meters to Feet: {MetersToFeet(meters)}");

            Console.Write("Enter feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Feet to Meters: {FeetToMeters(feet)}");


        }
    }
}
