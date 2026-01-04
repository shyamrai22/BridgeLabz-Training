using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class Book
    {

        public static string LibraryName = "ABC Library";
        public readonly string ISBN;

        // instance variables
        public string Title;
        public string Author;

        // using 'this' keyword
        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }

        // static method to display library name
        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name --> {LibraryName}");
        }

        // using 'is' operator
        public void DisplayDetails(object obj)
        {
            if (obj is Book)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Library --> {LibraryName}");
                Console.WriteLine($"Title   --> {Title}");
                Console.WriteLine($"Author  --> {Author}");
                Console.WriteLine($"ISBN    --> {ISBN}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not a Book");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book("Clean Code", "Robert C. Martin", "978-01323508");
            Book book2 = new Book("The Pragmatic Programmer", "Andrew Hunt", "978-02016224");

            Book.DisplayLibraryName();

            book1.DisplayDetails(book1);
            book2.DisplayDetails(book2);
            object obj = "Not book";
            book1.DisplayDetails(obj);
        }
    }
}
