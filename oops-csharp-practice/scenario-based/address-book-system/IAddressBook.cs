namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    interface IAddressBook
    {
        void AddContact(AddressBookSystem book, Contact contact);
        Contact GetContact(AddressBookSystem book, string name);
        bool DeleteContact(AddressBookSystem book, Contact contact);
        bool IsDuplicateContact(AddressBookSystem book, string firstName, string lastName);
        void PrintFrom(AddressBookSystem book, string location);
    }
}
