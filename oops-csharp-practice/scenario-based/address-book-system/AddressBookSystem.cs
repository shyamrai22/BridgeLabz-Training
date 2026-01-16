namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookSystem
    {
        public string Name { get; private set; }
        public Contact[] Contacts { get; private set; }
        public int ContactIndex { get; set; }

        public AddressBookSystem(string name, int capacity)
        {
            Name = name;
            Contacts = new Contact[capacity];
            ContactIndex = 0;
        }
    }
}
