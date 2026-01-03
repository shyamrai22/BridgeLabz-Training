using System;

/*
    Scenario: Bus Route Distance Tracker

    This program simulates a bus journey where the total distance travelled is tracked
    stop by stop. The user is presented with a menu to either add the distance for the
    next bus stop or exit the bus.

    Features:
    - Uses a menu-driven approach inside a while loop.
    - Tracks total distance travelled using a separate BusRouteDistanceTracker class.
    - Allows the passenger to decide when to get off the bus.
    - Displays the total distance travelled upon exit.
    - Demonstrates concepts of classes, methods, loops, and user input handling.

    Outcome:
    The program continues to accept stop distances until the passenger chooses
    to exit, after which the total distance travelled is displayed.
*/


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bus_route_distance_tracker
{
    class Caller
    {
        public static void Main(string[] args)
        {
            BusRouteDistanceTracker tracker = new BusRouteDistanceTracker();
            bool running = true;

            while (running)
            {
                Console.WriteLine("===== Bus Route Distance Tracker =====");
                Console.WriteLine("1. Add distance for coming stop");
                Console.WriteLine("2. Get off the bus");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter distance to next stop (in km): ");
                        double distance = double.Parse(Console.ReadLine());
                        tracker.AddStopDistance(distance);
                        break;

                    case 2:
                        tracker.DisplayTotalDistance();
                        Console.WriteLine("Passenger is exiting the bus....");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
