using System;

namespace BridgeLabzTraining.dsa_csharp_practice.library_management_system
{
    class Book
    {
        private int bookId;
        private string title;
        private string author;
        private string genre;
        private bool isAvailable;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public Book(int bookId, string title, string author, string genre, bool isAvailable)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isAvailable = isAvailable;
        }

        public void Display()
        {
            Console.WriteLine(
                $"ID: {BookId}, Title: {Title}, Author: {Author}, Genre: {Genre}, Available: {IsAvailable}"
            );
        }
    }
}
