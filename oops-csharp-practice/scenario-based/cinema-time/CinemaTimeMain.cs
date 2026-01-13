using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.cinema_time
{
    class BookBuddyMain
    {
        public static void Main()
        {
            CinemaTimeMenu menu = new CinemaTimeMenu();
            menu.Start();
            Console.ReadLine();
        }
    }
}
