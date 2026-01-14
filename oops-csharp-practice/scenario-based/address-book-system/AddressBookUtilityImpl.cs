using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookUtilityImpl : IAddressBook
    {
        private Contact[] AddressBook = new Contact[10];
        int AddressBookIndex = 0;

        public void AddContact(Contact contact)
        {
            if (AddressBookIndex >= AddressBook.Length)
            {
                Console.WriteLine("Address book is already full");
                return;
            }
            AddressBook[AddressBookIndex++] = contact;
        }

        public Contact GetContact(string name)
        {
            for(int i = 0; i < AddressBookIndex; i++)
            {
                if ($"{AddressBook[i].FirstName} {AddressBook[i].LastName}".Trim().Equals(name.Trim(),StringComparison.OrdinalIgnoreCase))
                {
                    return AddressBook[i];
                }
            }
            return null;
        } 


    }
}
