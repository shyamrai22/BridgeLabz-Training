using System;

namespace BridgeLabzTraining.oops_csharp_practice.class_and_object
{
    internal class BookDetails
    {
        public string title;
        public string author;
        public double price;


        public void Book()
        {
            BookDetails book = new BookDetails();
            book.title = "ABC";
            book.author = "XYZ";
            book.price = 1000;
            book.Display();
        }

        public void Display()
        {
            Console.WriteLine("Book Title -> " + title);
            Console.WriteLine("Author -> " + author);
            Console.WriteLine("Price -> " + price);
        }
    }
}