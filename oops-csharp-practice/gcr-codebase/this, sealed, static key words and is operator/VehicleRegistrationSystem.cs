using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class Vehicle
    {
        public static double RegistrationFee = 500;
        public readonly string RegistrationNumber;

        // instance variables
        public string OwnerName;
        public string VehicleType;

        // using 'this' keyword
        public Vehicle(string registrationNumber, string ownerName, string vehicleType)
        {
            this.RegistrationNumber = registrationNumber;
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
        }

        // method to update registration fee
        public static void UpdateRegistrationFee(double newFee)
        {
            if (newFee > 0)
            {
                RegistrationFee = newFee;
            }
            else
            {
                Console.WriteLine("Invalid registration fee");
            }
        }

        // using 'is' operator
        public void DisplayDetails(object obj)
        {
            if (obj is Vehicle)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Registration No --> {RegistrationNumber}");
                Console.WriteLine($"Owner Name      --> {OwnerName}");
                Console.WriteLine($"Vehicle Type    --> {VehicleType}");
                Console.WriteLine($"Registration Fee--> ₹{RegistrationFee}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not a Vehicle");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Vehicle vechile1 = new Vehicle("UP53AB1234", "Shyam", "Car");
            Vehicle vechile2 = new Vehicle("DL01XY5678", "Daman", "Bike");

            vechile1.DisplayDetails(vechile1);
            vechile2.DisplayDetails(vechile2);

            Vehicle.UpdateRegistrationFee(600);

            vechile1.DisplayDetails(vechile1);
            vechile2.DisplayDetails(vechile2);

            object obj = "Not a vehicle";
            vechile1.DisplayDetails(obj);
        }
    }
}
