using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Superclass
    class Book
    {
        public string Title;
        public int PublicationYear;

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        // Virtual method
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title            --> {Title}");
            Console.WriteLine($"Publication Year --> {PublicationYear}");
        }
    }

    // Subclass
    class Author : Book
    {
        public string Name;
        public string Bio;

        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        // Overriding
        public override void DisplayDetails()
        {
            Console.WriteLine("Book & Author Details");
            base.DisplayDetails();
            Console.WriteLine($"Author Name     --> {Name}");
            Console.WriteLine($"Author Bio      --> {Bio}");
            Console.WriteLine("--------------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Author book = new Author(
                "48 Laws Of Power",
                2012,
                "Robert Greene",
                "Author"
            );
            book.DisplayDetails();
        }
    }
}
