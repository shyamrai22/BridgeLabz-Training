using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMenu
    {
        private IAddressBook AddressBookService;

        public void StartA()
        {
            AddressBookService = new AddressBookUtilityImpl();

            // calling AddContact() from utility
            Console.WriteLine("Enter Contact Details");
            Console.WriteLine("----------------------");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip: ");
            string zip = Console.ReadLine();
            if (zip.Length != 6)
            {
                Console.WriteLine("Inavlid zip code entered!");
                return;
            }


            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber.Length != 10)
            {
                Console.WriteLine("Inavlid phone number entered!");
                return;
            }

            Console.Write("Email: ");
            string email = Console.ReadLine();

            // creating a Contact object
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

            AddressBookService.AddContact(contact);

            Console.WriteLine("Contact Added Successfully!");
            Console.WriteLine(contact); // calls Contact.ToString()
        }
    }
}
