using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    public class TrafficManagerMenu
    {
        private RoundaboutUtility roundabout;
        private EntryQueueUtility queue;

        public TrafficManagerMenu()
        {
            roundabout = new RoundaboutUtility();
            queue = new EntryQueueUtility(5);
        }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("--- Traffic Manager ---");
                Console.WriteLine("1. Add vehicle to queue");
                Console.WriteLine("2. Move vehicle to roundabout");
                Console.WriteLine("3. Remove vehicle from roundabout");
                Console.WriteLine("4. Display roundabout");
                Console.WriteLine("5. Display queue");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Vehicle ID: ");
                        queue.Enqueue(Console.ReadLine());
                        break;

                    case 2:
                        string vehicle = queue.Dequeue();
                        if (vehicle != null)
                            roundabout.AddVehicle(vehicle);
                        break;

                    case 3:
                        roundabout.RemoveVehicle();
                        break;

                    case 4:
                        roundabout.DisplayRoundabout();
                        break;

                    case 5:
                        queue.DisplayQueue();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}