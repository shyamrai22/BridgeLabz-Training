namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ride_hailing_application
{
    public class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(int id, string driver, double rate)
            : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return (distance * ratePerKm) + 20;
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
        }
    }
}
