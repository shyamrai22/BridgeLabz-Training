using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.book_buddy
{
    class BookBuddyMenu
    {
        private IBookBuddy bookBuddyService;
        public void Start()
        {
            bookBuddyService = new BookBuddyUtilityImpl();
            Console.WriteLine("Welcome to Book Buddy, Your very own library management app");
            Console.WriteLine("===========================================================");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. Sort the bookshelf");
                Console.WriteLine("3. Search for a book by author name");
                Console.WriteLine("4. Display books");
                Console.WriteLine("0. Exit application");
                Console.Write("Enter your choice --> ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the app.....");
                        break;
                    case 1:
                        Console.Write("Enter book name --> ");
                        string book = Console.ReadLine();
                        Console.Write("Enter author name --> ");
                        string author = Console.ReadLine();
                        bookBuddyService.AddBook(book, author);
                        break;

                    case 2:
                        bookBuddyService.SortBook();
                        break;

                    case 3:
                        Console.Write("Enter author name --> ");
                        string authorName = Console.ReadLine();
                        Console.WriteLine("Matched results");
                        bookBuddyService.SearchBookByAuthor(authorName);
                        break;

                    case 4:
                        Console.WriteLine("All books in library");
                        bookBuddyService.DisplayBooks();
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again");
                        break;
                }
            }
        }
    }
}
