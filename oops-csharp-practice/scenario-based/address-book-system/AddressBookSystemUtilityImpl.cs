using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookSystemUtilityImpl : IAddressBookSystem
    {
        private AddressBookSystem[] books;
        private int count;
        private string[] cities = new string[50];
        private Contact[][] cityContacts = new Contact[50][];
        private int[] cityCounts = new int[50];
        private int cityIndex = 0;

        private string[] states = new string[50];
        private Contact[][] stateContacts = new Contact[50][];
        private int[] stateCounts = new int[50];
        private int stateIndex = 0;


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

        public void IndexContact(Contact contact)
        {
            // ----- CITY -----
            int cityPos = FindIndex(cities, cityIndex, contact.City);

            if (cityPos == -1)
            {
                cities[cityIndex] = contact.City;
                cityContacts[cityIndex] = new Contact[20];
                cityContacts[cityIndex][0] = contact;
                cityCounts[cityIndex] = 1;
                cityIndex++;
            }
            else
            {
                cityContacts[cityPos][cityCounts[cityPos]++] = contact;
            }

            // ----- STATE -----
            int statePos = FindIndex(states, stateIndex, contact.State);

            if (statePos == -1)
            {
                states[stateIndex] = contact.State;
                stateContacts[stateIndex] = new Contact[20];
                stateContacts[stateIndex][0] = contact;
                stateCounts[stateIndex] = 1;
                stateIndex++;
            }
            else
            {
                stateContacts[statePos][stateCounts[statePos]++] = contact;
            }
        }

        // UC-09: View by City
        public void ViewPersonsByCity(string city)
        {
            int pos = FindIndex(cities, cityIndex, city);

            if (pos == -1)
            {
                Console.WriteLine("No persons found in this city.");
                return;
            }

            for (int i = 0; i < cityCounts[pos]; i++)
                Console.WriteLine(cityContacts[pos][i]);
        }

        // UC-09: View by State
        public void ViewPersonsByState(string state)
        {
            int pos = FindIndex(states, stateIndex, state);

            if (pos == -1)
            {
                Console.WriteLine("No persons found in this state.");
                return;
            }

            for (int i = 0; i < stateCounts[pos]; i++)
                Console.WriteLine(stateContacts[pos][i]);
        }

        private int FindIndex(string[] arr, int size, string value)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i].Equals(value, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
    }
}

