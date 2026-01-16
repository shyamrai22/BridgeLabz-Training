namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    interface IAddressBookSystem
    {
        bool AddAddressBook(string name);
        AddressBookSystem GetAddressBook(string name);
        void ShowAddressBooks();
        AddressBookSystem GetByIndex(int index);
        int Count { get; }
        void IndexContact(Contact contact);
        void ViewPersonsByCity(string city);
        void ViewPersonsByState(string state);
    }
}
