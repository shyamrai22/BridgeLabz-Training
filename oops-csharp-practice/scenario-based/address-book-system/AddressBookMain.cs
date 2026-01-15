using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMain
    {
        static void Main()
        {
            AddressBookMenu menu = new AddressBookMenu();

            // uc-00
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("-------------------------------");

            // uc-02
            //menu.StartA();

            //uc-03
            //menu.StartB();

            //uc-04
            //menu.StartC();
            
            //uc-05
            menu.StartD();

            Console.ReadLine();
        }
    }
}
