using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    class Bike : Vechile
    {
        protected double engineCC;
        protected string biketype;
        protected bool hasGear;

        public Bike(string vechileId, string brand, string model,
                    string registrationNumber, double engineCC,
                    string biketype, bool hasGear,
                    double baseRentPrice) : base(vechileId, brand, model, registrationNumber, baseRentPrice)
        {
            this.engineCC = engineCC;
            this.biketype = biketype;
            this.hasGear = hasGear;
        }

        public override double CalculateRent(int days)
        {
            double rent = baseRentPrice * days;
            
            if (engineCC > 300)
                rent += 0.2 * rent;
            
            return rent;
        }
    }
}
