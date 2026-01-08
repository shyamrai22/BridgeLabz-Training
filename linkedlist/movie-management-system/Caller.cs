using System;

namespace BridgeLabzTraining.dsa_csharp_practice.movie_management_system
{
    class Caller
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Movie Management System ---");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Remove by Title");
                Console.WriteLine("5. Search by Director");
                Console.WriteLine("6. Search by Rating");
                Console.WriteLine("7. Update Rating");
                Console.WriteLine("8. Display Forward");
                Console.WriteLine("9. Display Reverse");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddMovie(list, "beginning");
                        break;

                    case 2:
                        AddMovie(list, "end");
                        break;

                    case 3:
                        AddMovie(list, "position");
                        break;

                    case 4:
                        Console.Write("Enter movie title: ");
                        list.RemoveByTitle(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Enter director name: ");
                        list.SearchByDirector(Console.ReadLine());
                        break;

                    case 6:
                        Console.Write("Enter rating: ");
                        list.SearchByRating(double.Parse(Console.ReadLine()));
                        break;

                    case 7:
                        Console.Write("Enter movie title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter new rating: ");
                        double rating = double.Parse(Console.ReadLine());
                        list.UpdateRating(title, rating);
                        break;

                    case 8:
                        list.DisplayForward();
                        break;

                    case 9:
                        list.DisplayReverse();
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

        static void AddMovie(DoublyLinkedList list, string type)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Director: ");
            string director = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Rating: ");
            double rating = double.Parse(Console.ReadLine());

            Movie movie = new Movie(title, director, year, rating);

            if (type == "beginning")
                list.AddAtBeginning(movie);
            else if (type == "end")
                list.AddAtEnd(movie);
            else
            {
                Console.Write("Position: ");
                int pos = int.Parse(Console.ReadLine());
                list.AddAtPosition(movie, pos);
            }
        }
    }
}
