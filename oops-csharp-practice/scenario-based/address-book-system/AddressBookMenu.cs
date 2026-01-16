using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMenu
    {
        private AddressBookSystemUtilityImpl systemUtil = new AddressBookSystemUtilityImpl();
        private AddressBookUtilityImpl bookUtil = new AddressBookUtilityImpl();
        private AddressBookSystem selectedBook;

        // Helper: Select Address Book
        private bool SelectBook()
        {
            if (systemUtil.Count == 0)
            {
                Console.WriteLine("Create Address Book first (UC-06)");
                return false;
            }

            systemUtil.ShowAddressBooks();
            Console.Write("Enter Address Book Name: ");
            selectedBook = systemUtil.GetAddressBook(Console.ReadLine().Trim());

            if (selectedBook == null)
            {
                Console.WriteLine("Address Book not found!");
                return false;
            }
            return true;
        }

        // UC-02: Add Contact 
        public void StartUC2()
        {
            if (!SelectBook()) return;

            Contact contact = TakeInput(true);
            if (contact == null) return;

            bookUtil.AddContact(selectedBook, contact);

            // UC-09 indexing (IMPORTANT)
            systemUtil.IndexContact(contact);

            Console.WriteLine("Contact Added Successfully!");
        }

        // UC-03: Edit Contact
        public void StartUC3()
        {
            if (!SelectBook()) return;

            Console.Write("Enter full name: ");
            Contact c = bookUtil.GetContact(selectedBook, Console.ReadLine());
            if (c == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.Write("Enter new City: ");
            c.UpdateCity(Console.ReadLine());

            Console.WriteLine("Contact updated successfully!");
        }

        // UC-04: Delete Contact
        public void StartUC4()
        {
            if (!SelectBook()) return;

            Console.Write("Enter full name: ");
            Contact c = bookUtil.GetContact(selectedBook, Console.ReadLine());
            if (c == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            if (bookUtil.DeleteContact(selectedBook, c))
                Console.WriteLine("Contact deleted successfully!");
            else
                Console.WriteLine("Failed to delete contact.");
        }

        // UC-05: Add Multiple Contacts
        public void StartUC5()
        {
            if (!SelectBook()) return;

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Stop");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Contact contact = TakeInput(true);
                        if (contact == null) break;

                        bookUtil.AddContact(selectedBook, contact);

                        // UC-09 indexing
                        systemUtil.IndexContact(contact);

                        Console.WriteLine("Contact Added Successfully!");
                        break;

                    case 2:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // UC-06: Add Address Book
        public void StartUC6()
        {
            Console.Write("Enter Address Book Name: ");
            bool created = systemUtil.AddAddressBook(Console.ReadLine().Trim());

            Console.WriteLine(created
                ? "Address Book created successfully!"
                : "Address Book already exists!");
        }

        // UC-07: Prevent Duplicate
        public void StartUC7()
        {
            // UC-07 logic is enforced during add
            StartUC2();
        }

        // UC-08: Search by City or State 
        public void StartUC8()
        {
            Console.Write("Enter City or State: ");
            string loc = Console.ReadLine().Trim();

            for (int i = 0; i < systemUtil.Count; i++)
            {
                bookUtil.PrintFrom(systemUtil.GetByIndex(i), loc);
            }
        }
        
        // UC-09: Maintaining an dictionary of people based on city and state
        public void StartUC9()
        {
            Console.WriteLine("\nView persons by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter City: ");
                    systemUtil.ViewPersonsByCity(Console.ReadLine().Trim());
                    break;

                case 2:
                    Console.Write("Enter State: ");
                    systemUtil.ViewPersonsByState(Console.ReadLine().Trim());
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        public void StartUC10()
        {
            Console.WriteLine("Count contacts by:");
            Console.WriteLine("1. City");
            Console.WriteLine("2. State");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter City: ");
                    systemUtil.CountByCity(Console.ReadLine().Trim());
                    break;

                case 2:
                    Console.Write("Enter State: ");
                    systemUtil.CountByState(Console.ReadLine().Trim());
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        public void StartUC11()
        {
            if (!SelectBook()) return;
            bookUtil.SortByName(selectedBook);
        }


        // Input Helper
        private Contact TakeInput(bool checkDuplicate)
        {
            Console.Write("First Name: ");
            string fn = Console.ReadLine().Trim();

            Console.Write("Last Name: ");
            string ln = Console.ReadLine().Trim();

            if (checkDuplicate && bookUtil.IsDuplicateContact(selectedBook, fn, ln))
            {
                Console.WriteLine("Duplicate contact found!");
                return null;
            }

            Console.Write("Address: ");
            string ad = Console.ReadLine();

            Console.Write("City: ");
            string ct = Console.ReadLine();

            Console.Write("State: ");
            string st = Console.ReadLine();

            Console.Write("Zip: ");
            string zp = Console.ReadLine();

            Console.Write("Phone: ");
            string ph = Console.ReadLine();

            Console.Write("Email: ");
            string em = Console.ReadLine();

            return new Contact(fn, ln, ad, ct, st, zp, ph, em);
        }
    }
}
