using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.address_book_system
{
    class AddressBookMain
    {
        static void Main()
        {
            AddressBookMenu menu = new AddressBookMenu();
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("-------------------------------");
            
            // uc-01
            menu.StartA();
            
            //uc-02
            menu.StartB();
            
            Console.ReadLine();
        }
    }
}
