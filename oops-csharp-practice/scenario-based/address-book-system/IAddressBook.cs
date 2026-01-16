namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    interface IAddressBook
    {
        void AddContact(Contact contact);
        bool DeleteContact(Contact contact);
        Contact GetContact(string name);
        bool isDuplicateContact(string firstName, string lastName);
    }
}
