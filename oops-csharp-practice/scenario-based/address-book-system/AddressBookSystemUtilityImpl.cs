using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookSystemUtilityImpl : IAddressBookSystem
    {
        private AddressBookSystem[] books;
        private int count;

        public int Count => count;

        public AddressBookSystemUtilityImpl(int capacity = 5)
        {
            books = new AddressBookSystem[capacity];
            count = 0;
        }

        public bool AddAddressBook(string name)
        {
            if (count >= books.Length) return false;

            for (int i = 0; i < count; i++)
                if (books[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return false;

            books[count++] = new AddressBookSystem(name, 10);
            return true;
        }

        public AddressBookSystem GetAddressBook(string name)
        {
            for (int i = 0; i < count; i++)
                if (books[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return books[i];
            return null;
        }

        public AddressBookSystem GetByIndex(int index)
        {
            if (index < 0 || index >= count) return null;
            return books[index];
        }

        public void ShowAddressBooks()
        {
            if (count == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            for (int i = 0; i < count; i++)
                Console.WriteLine($"{i + 1}. {books[i].Name}");
        }
    }
}
