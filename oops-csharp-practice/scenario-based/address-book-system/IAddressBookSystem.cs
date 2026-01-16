namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    interface IAddressBookSystem
    {
        bool AddAddressBook(string name);

        AddressBookUtilityImpl GetAddressBook(string name);

        void ShowAddressBooks();

    }
}
