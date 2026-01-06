using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    class Car : Vechile
    {
        protected int numberOfSeats;
        protected string fuelType;
        protected string transmissionType;
        protected bool hasAC;

        public Car(string vechileId, string brand, string model, string registrationNumber,
                      int numberOfSeats, string fuelType, string transmissionType,
                      bool hasAC,
                      double baseRentPrice) : base(vechileId, brand, model, registrationNumber, baseRentPrice)
        {
            this.numberOfSeats = numberOfSeats;
            this.fuelType = fuelType;
            this.transmissionType = transmissionType;
            this.hasAC = hasAC;
        }

        public override double CalculateRent(int days)
        {
            double rent = baseRentPrice * days;

            if (numberOfSeats > 4 || hasAC)
                rent += 0.3 * rent;

            return rent;
        }
    }
}
