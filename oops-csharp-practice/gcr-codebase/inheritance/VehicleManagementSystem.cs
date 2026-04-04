using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Interface
    interface Refuelable
    {
        void Refuel();
    }

    // Superclass
    class Vehicle
    {
        public string Model;
        public int MaxSpeed;

        public Vehicle(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model --> {Model}");
            Console.WriteLine($"Max Speed --> {MaxSpeed} km/h");
        }
    }

    // ElectricVehicle
    class ElectricVehicle : Vehicle
    {
        public ElectricVehicle(string model, int maxSpeed) : base(model, maxSpeed)
        {
        }
        public void Charge()
        {
            Console.WriteLine("Vehicle is charging!!");
        }
    }

    // PetrolVehicle
    class PetrolVehicle : Vehicle, Refuelable
    {
        public PetrolVehicle(string model, int maxSpeed) : base(model, maxSpeed)
        {
        }
        public void Refuel()
        {
            Console.WriteLine("Vehicle is refueling...");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Vehicle vechile1 = new ElectricVehicle("Tesla", 225);
            Vehicle vechile2 = new PetrolVehicle("Creta", 180);

            vechile1.DisplayInfo();
            ((ElectricVehicle)vechile1).Charge();
            Console.WriteLine("--------------------------------");
            vechile2.DisplayInfo();
            ((Refuelable)vechile2).Refuel();
        }
    }
}
