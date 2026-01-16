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
            for(int i=0; i<AddressBookIndex; i++)
            {
                if (AddressBook[i].Equals(contact))
                {
                    Console.WriteLine("Contact already exists...");
                    return;
                }
            }
            AddressBook[AddressBookIndex++] = contact;
            Console.WriteLine("Contact Added Successfully!");
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

        public bool DeleteContact(Contact contact)
        {
            for (int i = 0; i < AddressBookIndex; i++)
            {
                string fullName =
                    $"{AddressBook[i].FirstName} {AddressBook[i].LastName}".Trim();

                string enteredName = $"{contact.FirstName} {contact.LastName}".Trim();

                if (fullName.Equals(enteredName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < AddressBookIndex - 1; j++)
                    {
                        AddressBook[j] = AddressBook[j + 1];
                    }

                    AddressBook[AddressBookIndex - 1] = null;
                    AddressBookIndex--;

                    return true;
                }
            }
            return false;
        }

        public bool isDuplicateContact(string firstName, string lastName)
        {
            for (int i = 0; i < AddressBookIndex; i++)
            {
                if (AddressBook[i].FirstName.Equals(firstName,StringComparison.OrdinalIgnoreCase) && AddressBook[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                } 
            }
            return false;
        }



    }
}
