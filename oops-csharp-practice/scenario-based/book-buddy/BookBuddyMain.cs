using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.book_buddy
{
    class BookBuddyMain
    {
        public static void Main()
        {
            BookBuddyMenu menu = new BookBuddyMenu();
            menu.Start();
            Console.ReadLine();
        }
    }
}
