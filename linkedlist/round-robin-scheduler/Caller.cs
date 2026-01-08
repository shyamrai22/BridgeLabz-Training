using System;

namespace BridgeLabzTraining.dsa_csharp_practice.round_robin_scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList scheduler = new CircularLinkedList();

            Console.Write("Enter Quantum: ");
            int quan = int.Parse(Console.ReadLine());

            int choice;
            do
            {
                Console.WriteLine("--- Round Robin Scheduler ---");
                Console.WriteLine("1. Add Process");
                Console.WriteLine("2. Start Scheduling");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Process ID: ");
                        int pid = int.Parse(Console.ReadLine());
                        Console.Write("Burst Time: ");
                        int bt = int.Parse(Console.ReadLine());
                        Console.Write("Priority: ");
                        int pr = int.Parse(Console.ReadLine());

                        scheduler.AddProcess(new Process(pid, bt, pr));
                        break;

                    case 2:
                        scheduler.Simulate(quan);
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
