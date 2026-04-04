namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ride_hailing_application
{
    public class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(int id, string driver, double rate)
            : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return (distance * ratePerKm) - 10;
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
