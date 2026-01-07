using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.vehicle_rental_system
{
    public abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        protected double rentalRate;

        public void SetVehicleNumber(string vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
        }

        public string GetVehicleNumber()
        {
            return vehicleNumber;
        }

        public void SetType(string type)
        {
            this.type = type;
        }

        public string GetType()
        {
            return type;
        }

        public void SetRentalRate(double rentalRate)
        {
            this.rentalRate = rentalRate;
        }

        public double GetRentalRate()
        {
            return rentalRate;
        }

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.rentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Vehicle Number : {vehicleNumber}");
            Console.WriteLine($"Vehicle Type   : {type}");
            Console.WriteLine($"Rate / Day     : {rentalRate}");
        }
    }
}
