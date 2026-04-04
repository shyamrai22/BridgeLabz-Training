namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.vehicle_rental_system
{
    public class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(string number, double rate, string policyNumber)
            : base(number, "Car", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return rentalRate * days;
        }

        public double CalculateInsurance()
        {
            return rentalRate * 0.15;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance 15%";
        }
    }
}
