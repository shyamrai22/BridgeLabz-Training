using BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system;

class AddressBookSystem : IAddressBookSystem
{
    private string[] addressBookNames = new string[10];
    private AddressBookUtilityImpl[] addressBooks = new AddressBookUtilityImpl[10];
    private int count = 0;

    public bool AddAddressBook(string name)
    {
        if (count >= addressBooks.Length)
        {
            Console.WriteLine("Address Book limit reached");
            return false;
        }

        // ensure unique names
        for (int i = 0; i < count; i++)
        {
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
        }

        addressBookNames[count] = name;
        addressBooks[count] = new AddressBookUtilityImpl();
        count++;
        return true;
    }

    public AddressBookUtilityImpl GetAddressBook(string name)
    {
        for (int i = 0; i < count; i++)
        {
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return addressBooks[i];
            }
        }
        return null;
    }

    public void ShowAddressBooks()
    {
        Console.WriteLine("Available Address Books:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}. {addressBookNames[i]}");
        }
    }
}
