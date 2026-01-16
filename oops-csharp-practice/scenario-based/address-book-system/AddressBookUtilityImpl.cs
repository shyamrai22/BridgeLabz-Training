using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookUtilityImpl : IAddressBook
    {
        public void AddContact(AddressBookSystem book, Contact contact)
        {
            if (book.ContactIndex >= book.Contacts.Length)
            {
                Console.WriteLine("Address Book is full");
                return;
            }

            for (int i = 0; i < book.ContactIndex; i++)
            {
                if (book.Contacts[i].Equals(contact))
                {
                    Console.WriteLine("Duplicate contact found");
                    return;
                }
            }

            book.Contacts[book.ContactIndex++] = contact;
        }

        public Contact GetContact(AddressBookSystem book, string name)
        {
            for (int i = 0; i < book.ContactIndex; i++)
            {
                string fullName =
                    $"{book.Contacts[i].FirstName} {book.Contacts[i].LastName}".Trim();

                if (fullName.Equals(name.Trim(), StringComparison.OrdinalIgnoreCase))
                    return book.Contacts[i];
            }
            return null;
        }

        public bool DeleteContact(AddressBookSystem book, Contact contact)
        {
            for (int i = 0; i < book.ContactIndex; i++)
            {
                if (book.Contacts[i].Equals(contact))
                {
                    for (int j = i; j < book.ContactIndex - 1; j++)
                        book.Contacts[j] = book.Contacts[j + 1];

                    book.Contacts[--book.ContactIndex] = null;
                    return true;
                }
            }
            return false;
        }

        public bool IsDuplicateContact(AddressBookSystem book, string firstName, string lastName)
        {
            for (int i = 0; i < book.ContactIndex; i++)
            {
                if (book.Contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase)
                 && book.Contacts[i].LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        public void PrintFrom(AddressBookSystem book, string location)
        {
            for (int i = 0; i < book.ContactIndex; i++)
            {
                if (book.Contacts[i].City.Equals(location, StringComparison.OrdinalIgnoreCase)
                 || book.Contacts[i].State.Equals(location, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(book.Contacts[i]);
                }
            }
        }
    }
}
