using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMenu
    {
        private AddressBookSystemUtilityImpl systemUtil = new AddressBookSystemUtilityImpl();
        private AddressBookUtilityImpl bookUtil = new AddressBookUtilityImpl();
        private AddressBookSystem selectedBook;

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

        public void StartUC2()
        {
            if (!SelectBook()) return;
            Contact c = TakeInput(true);
            if (c != null) bookUtil.AddContact(selectedBook, c);
        }

        public void StartUC3()
        {
            if (!SelectBook()) return;
            Console.Write("Enter name: ");
            Contact c = bookUtil.GetContact(selectedBook, Console.ReadLine());
            if (c == null) return;

            Console.Write("New City: ");
            c.UpdateCity(Console.ReadLine());
        }

        public void StartUC4()
        {
            if (!SelectBook()) return;
            Console.Write("Enter name: ");
            Contact c = bookUtil.GetContact(selectedBook, Console.ReadLine());
            if (c != null) bookUtil.DeleteContact(selectedBook, c);
        }

        public void StartUC5() => StartUC2();

        public void StartUC6()
        {
            Console.Write("Enter Address Book Name: ");
            Console.WriteLine(
                systemUtil.AddAddressBook(Console.ReadLine().Trim())
                ? "Created" : "Already exists");
        }

        public void StartUC7() => StartUC2();

        public void StartUC8()
        {
            Console.Write("Enter City or State: ");
            string loc = Console.ReadLine();
            for (int i = 0; i < systemUtil.Count; i++)
                bookUtil.PrintFrom(systemUtil.GetByIndex(i), loc);
        }

        private Contact TakeInput(bool checkDuplicate)
        {
            Console.Write("First Name: ");
            string fn = Console.ReadLine().Trim();
            Console.Write("Last Name: ");
            string ln = Console.ReadLine().Trim();

            if (checkDuplicate && bookUtil.IsDuplicateContact(selectedBook, fn, ln))
            {
                Console.WriteLine("Duplicate contact");
                return null;
            }

            Console.Write("Address: "); string ad = Console.ReadLine();
            Console.Write("City: "); string ct = Console.ReadLine();
            Console.Write("State: "); string st = Console.ReadLine();
            Console.Write("Zip: "); string zp = Console.ReadLine();
            Console.Write("Phone: "); string ph = Console.ReadLine();
            Console.Write("Email: "); string em = Console.ReadLine();

            return new Contact(fn, ln, ad, ct, st, zp, ph, em);
        }
    }
}
