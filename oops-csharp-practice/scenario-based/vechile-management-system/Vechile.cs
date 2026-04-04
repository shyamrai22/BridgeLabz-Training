using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    abstract class Vechile : IRentable
    {
        protected string vechileId;
        protected string brand;
        protected string model;
        protected string registrationNumber;
        protected double baseRentPrice;

        public Vechile(string vechileId, string brand, string model, string registrationNumber, double baseRentPrice)
        {
            this.vechileId = vechileId;
            this.brand = brand;
            this.model = model;
            this.registrationNumber = registrationNumber;
            this.baseRentPrice = baseRentPrice;
        }
        public abstract double CalculateRent(int days);
    }
}
