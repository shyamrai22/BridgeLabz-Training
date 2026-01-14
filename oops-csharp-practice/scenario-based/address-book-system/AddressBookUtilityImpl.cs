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
            AddressBook[AddressBookIndex] = contact;
        }

    }
}
