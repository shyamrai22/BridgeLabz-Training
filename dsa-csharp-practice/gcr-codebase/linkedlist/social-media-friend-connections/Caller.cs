using System;

namespace BridgeLabzTraining.dsa_csharp_practice.social_media_friend_connections
{
    class Caller
    {
        public static void Main(string[] args)
        {
            SinglyLinkedList nets = new SinglyLinkedList();
            int choice;

            do
            {
                Console.WriteLine("--- Social Media Friend System ---");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Friend Connection");
                Console.WriteLine("3. Remove Friend Connection");
                Console.WriteLine("4. Display Friends of User");
                Console.WriteLine("5. Find Mutual Friends");
                Console.WriteLine("6. Search by User ID");
                Console.WriteLine("7. Search by Name");
                Console.WriteLine("8. Count Friends");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("User ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        nets.AddUser(new User(id, name, age));
                        break;

                    case 2:
                        Console.Write("User ID 1: ");
                        int u1 = int.Parse(Console.ReadLine());
                        Console.Write("User ID 2: ");
                        int u2 = int.Parse(Console.ReadLine());
                        nets.AddFriend(u1, u2);
                        break;

                    case 3:
                        Console.Write("User ID 1: ");
                        int r1 = int.Parse(Console.ReadLine());
                        Console.Write("User ID 2: ");
                        int r2 = int.Parse(Console.ReadLine());
                        nets.RemoveFriend(r1, r2);
                        break;

                    case 4:
                        Console.Write("User ID: ");
                        nets.DisplayFriends(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("User ID 1: ");
                        int m1 = int.Parse(Console.ReadLine());
                        Console.Write("User ID 2: ");
                        int m2 = int.Parse(Console.ReadLine());
                        nets.FindMutualFriends(m1, m2);
                        break;

                    case 6:
                        Console.Write("User ID: ");
                        nets.SearchById(int.Parse(Console.ReadLine()));
                        break;

                    case 7:
                        Console.Write("Name: ");
                        nets.SearchByName(Console.ReadLine());
                        break;

                    case 8:
                        nets.CountFriends();
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
