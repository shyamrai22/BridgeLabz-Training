using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Book
    {
        private string title;
        private string author;
        private int price;

        // default constructor
        public Book()
        {
            title = "Na";
            author = "Na";
            price = 0;
        }
        
        // parameterised constructor
        public Book(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // method to display fields
        public void Display()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Title --> {title}");
            Console.WriteLine($"Author --> {author}");
            Console.WriteLine($"Price --> {price}");
            Console.WriteLine("===================");
        }
    }

    // class with main method
    class Caller
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Robert Greene", "48 Laws Of Power", 500);

            book1.Display();
            book2.Display();
        }
    }
}
