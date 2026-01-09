using System;

namespace BridgeLabzTraining.dsa_csharp_practice.library_management_system
{
    class Caller
    {
        static void Main(string[] args)
        {
            DoublyLinkedList library = new DoublyLinkedList();
            int choice;

            do
            {
                Console.WriteLine("--- Library Management System ---");
                Console.WriteLine("1. Add Book at Beginning");
                Console.WriteLine("2. Add Book at End");
                Console.WriteLine("3. Add Book at Position");
                Console.WriteLine("4. Remove Book by ID");
                Console.WriteLine("5. Search by Title");
                Console.WriteLine("6. Search by Author");
                Console.WriteLine("7. Update Availability");
                Console.WriteLine("8. Display Forward");
                Console.WriteLine("9. Display Reverse");
                Console.WriteLine("10. Count Books");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.Write("Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Available (true/false): ");
                        bool available = bool.Parse(Console.ReadLine());

                        Book book = new Book(id, title, author, genre, available);

                        if (choice == 1)
                            library.AddAtBeginning(book);
                        else if (choice == 2)
                            library.AddAtEnd(book);
                        else
                        {
                            Console.Write("Position: ");
                            int pos = int.Parse(Console.ReadLine());
                            library.AddAtPosition(book, pos);
                        }
                        break;

                    case 4:
                        Console.Write("Book ID: ");
                        library.RemoveByBookId(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Title: ");
                        library.SearchByTitle(Console.ReadLine());
                        break;

                    case 6:
                        Console.Write("Author: ");
                        library.SearchByAuthor(Console.ReadLine());
                        break;

                    case 7:
                        Console.Write("Book ID: ");
                        int bid = int.Parse(Console.ReadLine());
                        Console.Write("Available (true/false): ");
                        bool status = bool.Parse(Console.ReadLine());
                        library.UpdateAvailability(bid, status);
                        break;

                    case 8:
                        library.DisplayForward();
                        break;

                    case 9:
                        library.DisplayReverse();
                        break;

                    case 10:
                        library.CountBooks();
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
