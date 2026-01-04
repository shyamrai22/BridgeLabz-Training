using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Superclass
    class Vehicle
    {
        public int MaxSpeed;
        public string FuelType;

        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        // Virtual method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed --> {MaxSpeed} km/h");
            Console.WriteLine($"Fuel Type --> {FuelType}");
        }
    }

    // Car subclass
    class Car : Vehicle
    {
        public int SeatCapacity;

        public Car(int maxSpeed, string fuelType, int seatCapacity) : base(maxSpeed, fuelType)
        {
            SeatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Car ----");
            base.DisplayInfo();
            Console.WriteLine($"Seat Capacity --> {SeatCapacity}");
            Console.WriteLine("--------------------------------------");
        }
    }

    // Truck subclass
    class Truck : Vehicle
    {
        public int PayloadCapacity; 

        public Truck(int maxSpeed, string fuelType, int payloadCapacity) : base(maxSpeed, fuelType)
        {
            PayloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Truck ----");
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity --> {PayloadCapacity} tons");
            Console.WriteLine("--------------------------------------");
        }
    }

    // Motorcycle subclass
    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Motorcycle ----");
            base.DisplayInfo();
            Console.WriteLine($"Has sidecar --> {HasSidecar}");
            Console.WriteLine("--------------------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Vehicle[] vehicles = {
                                    new Car(180, "Petrol", 5),
                                    new Truck(120, "Diesel", 15),
                                    new Motorcycle(160, "Petrol", false)
                                 };

            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
