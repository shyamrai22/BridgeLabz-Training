using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMain
    {
        static void Main()
        {
            AddressBookMenu menu = new AddressBookMenu();
            bool exit = false;

            Console.WriteLine("Welcome to Address Book Program");

            while (!exit)
            {
                Console.WriteLine("\n1 UC-02 Add Contact");
                Console.WriteLine("2 UC-03 Edit Contact");
                Console.WriteLine("3 UC-04 Delete Contact");
                Console.WriteLine("4 UC-05 Add Multiple Contacts");
                Console.WriteLine("5 UC-06 Add Address Book");
                Console.WriteLine("6 UC-07 Prevent Duplicate");
                Console.WriteLine("7 UC-08 Search City/State");
                Console.WriteLine("8 Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: menu.StartUC2(); break;
                    case 2: menu.StartUC3(); break;
                    case 3: menu.StartUC4(); break;
                    case 4: menu.StartUC5(); break;
                    case 5: menu.StartUC6(); break;
                    case 6: menu.StartUC7(); break;
                    case 7: menu.StartUC8(); break;
                    case 8: exit = true; break;
                }
            }
        }
    }
}
