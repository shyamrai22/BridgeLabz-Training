using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Book
    {
        public string ISBN;
        protected string title;
        private string author;

        // constructor
        public Book(string isbn, string title, string author)
        {
            this.ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        // Method to get author
        public string GetAuthor()
        {
            return author;
        }

        // Method to set author
        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }

    // subclass to demonstrate access modifiers
    class EBook : Book
    {
        private string fileFormat;

        public EBook(string isbn, string title, string author, string fileFormat)
            : base(isbn, title, author)
        {
            this.fileFormat = fileFormat;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("============================");
            Console.WriteLine($"ISBN        --> {ISBN}");   
            Console.WriteLine($"Title       --> {title}");  
            Console.WriteLine($"Author      --> {GetAuthor()}"); 
            Console.WriteLine($"File Format --> {fileFormat}");
            Console.WriteLine("============================");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            EBook ebook1 =
                new EBook("978-0132384", "Clean Code", "Robert C. Martin", "PDF");

            ebook1.DisplayDetails();
            ebook1.SetAuthor("Bob Martins");
            Console.WriteLine("Updated Author --> " + ebook1.GetAuthor());
        }
    }
}
