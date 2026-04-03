using System;

/*
    LibraryManagementSystem is a console-based application that simulates a basic
    library management system using a 2D string array. The system supports two
    types of users: Admin and Guest, verified through a simple passkey mechanism.

    Key features include:
    - User verification (Admin or Guest)
    - Issuing books (Admin only)
    - Returning books (Admin only)
    - Searching books by exact title
    - Displaying all books with their author and availability status

    Books are stored in a fixed-size 2D array with columns representing
    Book Name, Author, and Status (Available/Issued). The application demonstrates
    core C# fundamentals such as arrays, loops, conditional statements, methods,
    string comparison, and basic access control without using collections.
*/


namespace BridgeLabzTraining.scenario_based._30th_December
{
    internal class LibraryManagementSystem
    {
        static bool admin = false;
        private static string passkey = "121212";
        static string adminName = "Shyam";
        
        // Method is used to check if user is guest or admin.
        private static void CheckUser()
        {
            string ans = "";
            Console.WriteLine("Q--> Are you a guest. y/n (Yes/No)");
            Console.Write("A--> ");
            ans = Console.ReadLine();
            if(ans.ToLower() == "y")
            {
                admin = false;
                Console.WriteLine("Welcome User");
            } 
            else if(ans.ToLower() == "n")
            {
                Console.Write("Enter the code to verify --> ");
                string inputPasskey = Console.ReadLine();
                if(inputPasskey == passkey)
                {
                    admin = true;
                    Console.WriteLine("Admin verified");
                    Console.WriteLine($"Welcome {adminName}");
                }
                else
                {
                    Console.WriteLine("Code entered is wrong.");
                    CheckUser();
                }
            }
            else
            {
                Console.WriteLine("Give valid input!!");
                CheckUser();
            }



        }

        // Method is used to take back a book 
        public static void ReturnBook(string[,] bookDatabase)
        {
            Console.Write("Enter name of the book --> ");
            string name = Console.ReadLine();

            for (int record = 0; record < bookDatabase.GetLength(0); record++)
            {
                if (bookDatabase[record, 0].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (bookDatabase[record, 2] == "Issued")
                    {
                        bookDatabase[record, 2] = "Available";
                        Console.WriteLine("Book returned successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book is already available.");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        // Method is used to issue a book
        public static void IssueBook(string[,] bookDatabase)
        {
            Console.Write("Enter name of the book --> ");
            string name = Console.ReadLine();

            for (int record = 0; record < bookDatabase.GetLength(0); record++)
            {
                if (bookDatabase[record, 0].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    if (bookDatabase[record, 2] == "Available")
                    {
                        bookDatabase[record, 2] = "Issued";
                        Console.WriteLine("Book issued successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Book is already issued.");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        // Method is used to search for a book in database
        public static void SearchBook(string[,] bookDatabase)
        {
            Console.Write("Enter name of the book --> ");
            string name = Console.ReadLine();
            bool found = false;

            for (int record = 0; record < bookDatabase.GetLength(0); record++)
            {
                // OrdinalIgnoreCase is used to check for similarity between strings without taking case  into account
                if (bookDatabase[record, 0].IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0) 
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Bookname --> {bookDatabase[record,0]}");
                    Console.WriteLine($"Author --> {bookDatabase[record,1]}");
                    Console.WriteLine($"Status --> {bookDatabase[record,2]}");
                    Console.WriteLine("-------------------------------------");
                    found = true;
                }
            }
            if(!found)
                Console.WriteLine("Book not found.");
        }
        
        // Method is used to display all the books in database
        public static void DisplayAllBooks(string[,] bookDatabase)
        {
            Console.WriteLine(" All books are listed below ");

            for (int record = 0; record < bookDatabase.GetLength(0); record++)
            {
                    Console.WriteLine($"{record+1}--> Bookname : {bookDatabase[record, 0]}||Author : {bookDatabase[record, 1]}||Status : {bookDatabase[record, 2]}");          
            }
        }
        
        // This method acts as a main method. All the above methods are called here to make the application work.
        public static void Caller()
        {
            Console.WriteLine("Welcome to your own library management system.");
            CheckUser();
            string[,] bookDatabase =   {
                                            { "The Alchemist", "Paulo Coelho", "Available" },
                                            { "1984", "George Orwell", "Issued" },
                                            { "To Kill a Mockingbird", "Harper Lee", "Available" },
                                            { "The Great Gatsby", "F. Scott Fitzgerald", "Available" },
                                            { "Atomic Habits", "James Clear", "Issued" },
                                            { "Rich Dad Poor Dad", "Robert Kiyosaki", "Available" },
                                            { "Think and Grow Rich", "Napoleon Hill", "Issued" },
                                            { "The Power of Habit", "Charles Duhigg", "Available" },
                                            { "Clean Code", "Robert C. Martin", "Issued" },
                                            { "Sapiens", "Yuval Noah Harari", "Available" }
                                       };

            // Menu made using switch for admin
            if (admin)
            {
                Console.WriteLine("What action do you want to perform?");
                Console.WriteLine("1. Take back a book");
                Console.WriteLine("2. Issue a book");
                Console.WriteLine("3. Search for a book");
                Console.WriteLine("4. Display all available books");
                Console.Write("Enter your choice (1/2/3/4) --> ");
                
                int choice = int.Parse(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                        ReturnBook(bookDatabase);
                        break;

                    case 2:
                        IssueBook(bookDatabase);                        
                        break;

                    case 3:
                        SearchBook(bookDatabase);                        
                        break;

                    case 4:
                        DisplayAllBooks(bookDatabase);
                        break;
                }

            }
            // Menu made using switch for user
            else
            {
                Console.WriteLine("What action do you want to perform?");
                Console.WriteLine("1. Search for a book");
                Console.WriteLine("2. Display all books");
                Console.Write("Enter your choice (1/2) --> ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SearchBook(bookDatabase);
                        break;

                    case 2:
                        DisplayAllBooks(bookDatabase);
                        break; 
                }
            }
        }
    }
}
