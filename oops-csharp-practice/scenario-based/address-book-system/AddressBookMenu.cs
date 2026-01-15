using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMenu
    {
        private IAddressBook AddressBookService;

        // Constructor → single shared instance
        public AddressBookMenu()
        {
            AddressBookService = new AddressBookUtilityImpl();
        }

        // added a feature to add a contact
        public void StartA()
        {
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

        // searching a contact in address book by name and then updating the required property
        public void StartB()
        {
            Console.WriteLine("Enter the name to search");
            string name = (Console.ReadLine()).Trim();
            Contact contactToUpdate = AddressBookService.GetContact(name);
            if (contactToUpdate == null)
            {
                Console.WriteLine("No match found!");
                return;
            }
            Console.WriteLine("What do you want to edit?");
            Console.WriteLine("1. Address");
            Console.WriteLine("2. City");
            Console.WriteLine("3. State");
            Console.WriteLine("4. Zip");
            Console.WriteLine("5. Phone Number");
            Console.WriteLine("6. Email");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter new value: ");
            string newValue = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    contactToUpdate.UpdateAddress(newValue);
                    break;

                case 2:
                    contactToUpdate.UpdateCity(newValue);
                    break;

                case 3:
                    contactToUpdate.UpdateState(newValue);
                    break;

                case 4:
                    contactToUpdate.UpdateZip(newValue);
                    break;

                case 5:
                    contactToUpdate.UpdatePhoneNumber(newValue);
                    break;

                case 6:
                    contactToUpdate.UpdateEmail(newValue);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.WriteLine("Contact Updated Successfully!");
            Console.WriteLine(contactToUpdate);
        }

        // searching a contact in address book by name and then deleting it
        public void StartC()
        {
            Console.WriteLine("Enter the name to search");
            string name = (Console.ReadLine()).Trim();
            Contact contactToDelete = AddressBookService.GetContact(name);
            if (contactToDelete == null)
            {
                Console.WriteLine("No match found!");
                return;
            }
            Console.WriteLine("Do you want to delete the contact?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bool done = AddressBookService.DeleteContact(contactToDelete);
                    if (done)
                        Console.WriteLine("Contact deleted successfully");
                    else
                        Console.WriteLine("Contact not deleted due to some error");
                    break;

                case 2:
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        // adding multiple contacts to address book

        public void StartD()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Do you want to add a contact ");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("Enter your choice --> ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
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
                            continue;
                        }


                        Console.Write("Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        if (phoneNumber.Length != 10)
                        {
                            Console.WriteLine("Inavlid phone number entered!");
                            continue;
                        }

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        // creating a Contact object
                        Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

                        AddressBookService.AddContact(contact);

                        Console.WriteLine("Contact Added Successfully!");
                        Console.WriteLine(contact); // calls Contact.ToString()
                        break;

                    case 2:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }

        }
    }
}
