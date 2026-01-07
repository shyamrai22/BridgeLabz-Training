using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.library_management_system
{
    public abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        protected bool isAvailable = true;


        public int GetItemId()
        {
            return itemId;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public LibraryItem(int itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }
        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item ID     : {itemId}");
            Console.WriteLine($"Title       : {title}");
            Console.WriteLine($"Author      : {author}");
            Console.WriteLine($"Availability: {(isAvailable ? "Available" : "Not Available")}");
        }
    }
}
