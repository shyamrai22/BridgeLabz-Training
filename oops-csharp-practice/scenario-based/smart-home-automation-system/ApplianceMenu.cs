using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    class ApplianceMenu
    {
        public static void ShowMenu()
        {
            IControllable appliance = null;

            Console.WriteLine("=== Smart Home Automation System ===");
            Console.WriteLine("1. Light");
            Console.WriteLine("2. Fan");
            Console.WriteLine("3. AC");
            Console.Write("Choose an appliance: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    appliance = new Light("L1", "Philips Light", "1.0");
                    break;

                case 2:
                    appliance = new Fan("F1", "Crompton Fan", "1.2");
                    break;

                case 3:
                    appliance = new Ac("AC1", "Samsung AC", "2.0");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            while (true)
            {
                Console.WriteLine("\n--- Appliance Control Menu ---");
                Console.WriteLine("1. Turn ON");
                Console.WriteLine("2. Turn OFF");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        appliance.TurnOn();
                        break;

                    case 2:
                        appliance.TurnOff();
                        break;

                    case 3:
                        Console.WriteLine("Exiting appliance menu...");
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
