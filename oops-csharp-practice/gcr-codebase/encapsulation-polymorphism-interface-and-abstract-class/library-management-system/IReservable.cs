namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.library_management_system
{
    public interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }
}
