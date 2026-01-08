using System;

namespace BridgeLabzTraining.dsa_csharp_practice.task_scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList scheduler = new CircularLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Task Scheduler ---");
                Console.WriteLine("1. Add Task at Beginning");
                Console.WriteLine("2. Add Task at End");
                Console.WriteLine("3. Add Task at Position");
                Console.WriteLine("4. Remove Task by ID");
                Console.WriteLine("5. View Current Task & Move Next");
                Console.WriteLine("6. Display All Tasks");
                Console.WriteLine("7. Search by Priority");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.Write("Task ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Task Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Priority: ");
                        int priority = int.Parse(Console.ReadLine());
                        Console.Write("Due Date: ");
                        string due = Console.ReadLine();

                        TaskItem task = new TaskItem(id, name, priority, due);

                        if (choice == 1)
                            scheduler.AddAtBeginning(task);
                        else if (choice == 2)
                            scheduler.AddAtEnd(task);
                        else
                        {
                            Console.Write("Position: ");
                            int pos = int.Parse(Console.ReadLine());
                            scheduler.AddAtPosition(task, pos);
                        }
                        break;

                    case 4:
                        Console.Write("Enter Task ID: ");
                        scheduler.RemoveByTaskId(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        scheduler.ViewCurrentAndMoveNext();
                        break;

                    case 6:
                        scheduler.DisplayAll();
                        break;

                    case 7:
                        Console.Write("Enter Priority: ");
                        scheduler.SearchByPriority(int.Parse(Console.ReadLine()));
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
