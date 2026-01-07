namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.ride_hailing_application
{
    public interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation(string location);
    }
}
