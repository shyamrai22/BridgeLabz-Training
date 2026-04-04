using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.vechile_management_system
{
    class Truck : Vechile
    {
        protected int loadCapacityInTons;
        protected int numberOfAxles;
        protected bool isCommercial;

        public Truck(string vechileId, string brand, string model,
                        string registrationNumber, int loadCapacityInTons,
                        int numberOfAxles, bool isCommercial,
                        double baseRentPrice) : base(vechileId, brand, model, registrationNumber, baseRentPrice)
        {
            this.loadCapacityInTons = loadCapacityInTons;
            this.numberOfAxles = numberOfAxles;
            this.isCommercial = isCommercial;
        }

        public override double CalculateRent(int days)
        {
            double rent = baseRentPrice * days;

            if (loadCapacityInTons > 4 || isCommercial)
                rent += 0.4 * rent;

            return rent;
        }
    }
}
