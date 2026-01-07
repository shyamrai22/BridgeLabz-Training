namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.vehicle_rental_system
{
    public class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Bike(string number, double rate, string policyNumber)
            : base(number, "Bike", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return rentalRate * 0.10;
        }

        public string GetInsuranceDetails()
        {
            return "Bike Insurance 10%";
        }
    }
}
