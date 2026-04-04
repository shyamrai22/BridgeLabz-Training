namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.vehicle_rental_system
{
    public class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Truck(string number, double rate, string policyNumber)
            : base(number, "Truck", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return (rentalRate * days) + 2000;
        }

        public double CalculateInsurance()
        {
            return rentalRate * 0.20;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance @20%";
        }
    }
}
