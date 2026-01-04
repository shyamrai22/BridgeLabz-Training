using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    internal class Library
    {
        public string title;
        public string author;
        public double price;
        public bool available;

        public Library(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            available = true;
        }

        // To borrow a book
        public void Borrow()
        {
            if (available)
            {
                available = false;
                Console.WriteLine("You have borrowed this book.");
            }
            else
            {
                Console.WriteLine("Currently not available.");
            }
        }


        // To display book details
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Availability:{(available ? "Available" : "Not Available")}");
        }


        // To demonstrate the class
        public static void Main(string[] args)
        {
            Library book1 = new Library("book 1", "Shyam", 1000);

            book1.DisplayDetails();
            book1.Borrow();
            book1.Borrow();
            book1.DisplayDetails();
        }
    }
}
