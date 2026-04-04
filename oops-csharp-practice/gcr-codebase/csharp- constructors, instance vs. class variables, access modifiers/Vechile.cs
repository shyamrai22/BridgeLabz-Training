using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Vehicle
    {
        // instance variables
        private string ownerName;
        private string vehicleType;

        // class variable
        private static int registrationFee = 3000;

        // parameterized constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        // instance method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Owner Name        --> {ownerName}");
            Console.WriteLine($"Vehicle Type      --> {vehicleType}");
            Console.WriteLine($"Registration Fee  --> {registrationFee}");
            Console.WriteLine("------------------------------");
        }

        // class method
        public static void UpdateRegistrationFee(int newFee)
        {
            registrationFee = newFee;
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Vehicle vechile1 = new Vehicle("Shyam", "Car");
            Vehicle vechile2 = new Vehicle("Raman", "Bike");

            vechile1.DisplayVehicleDetails();
            vechile2.DisplayVehicleDetails();

            Vehicle.UpdateRegistrationFee(5000);

            vechile1.DisplayVehicleDetails();
            vechile2.DisplayVehicleDetails();
        }
    }
}
