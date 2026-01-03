using System;

/*
    Class: BusRouteDistanceTracker

    This class is responsible for tracking the total distance travelled during a bus journey.
    It maintains a running total of distance and provides methods to add distance for each
    bus stop and display the final distance travelled.

    Key Responsibilities:
    - Store and update the total distance using a private variable.
    - Add distance for each stop through the AddStopDistance() method.
    - Display the total distance travelled using the DisplayTotalDistance() method.

    Concepts Used:
    Encapsulation, Methods, Access Modifiers, and Console Output.
*/


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bus_route_distance_tracker
{

    class BusRouteDistanceTracker
    {
        private double totalDistance = 0;

        // Method to add distance for a stop
        public void AddStopDistance(double distance)
        {
            totalDistance += distance;
            Console.WriteLine($"Distance added: {distance} km");
            Console.WriteLine($"Total distance so far: {totalDistance} km");
            Console.WriteLine("===========================================");
        }

        // Method to display total distance
        public void DisplayTotalDistance()
        {
            Console.WriteLine($"Total distance travelled: {totalDistance} km");
            Console.WriteLine("=============================================");
        }
    }
}
