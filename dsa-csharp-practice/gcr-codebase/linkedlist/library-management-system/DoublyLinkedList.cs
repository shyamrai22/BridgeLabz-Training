using System;

namespace BridgeLabzTraining.dsa_csharp_practice.library_management_system
{
    class DoublyLinkedList
    {
        private DoublyNode head;
        private DoublyNode tail;

        // Add at beginning
        public void AddAtBeginning(Book book)
        {
            DoublyNode newNode = new DoublyNode(book);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(Book book)
        {
            DoublyNode newNode = new DoublyNode(book);

            if (tail == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        // Add at position (1-based)
        public void AddAtPosition(Book book, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(book);
                return;
            }

            DoublyNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null || temp.Next == null)
            {
                AddAtEnd(book);
                return;
            }

            DoublyNode newNode = new DoublyNode(book);
            newNode.Next = temp.Next;
            newNode.Previous = temp;
            temp.Next.Previous = newNode;
            temp.Next = newNode;
        }

        // Remove by Book ID
        public void RemoveByBookId(int bookId)
        {
            DoublyNode temp = head;

            while (temp != null)
            {
                if (temp.Data.BookId == bookId)
                {
                    if (temp == head)
                    {
                        head = head.Next;
                        if (head != null)
                            head.Previous = null;
                    }
                    else if (temp == tail)
                    {
                        tail = tail.Previous;
                        tail.Next = null;
                    }
                    else
                    {
                        temp.Previous.Next = temp.Next;
                        temp.Next.Previous = temp.Previous;
                    }

                    Console.WriteLine("Book removed successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Book not found.");
        }

        // Search by Title
        public void SearchByTitle(string title)
        {
            DoublyNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Data.Title.Equals(title))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Book not found.");
        }

        // Search by Author
        public void SearchByAuthor(string author)
        {
            DoublyNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Data.Author.Equals(author))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No books found for this author.");
        }

        // Update availability
        public void UpdateAvailability(int bookId, bool status)
        {
            DoublyNode temp = head;

            while (temp != null)
            {
                if (temp.Data.BookId == bookId)
                {
                    temp.Data.IsAvailable = status;
                    Console.WriteLine("Availability updated.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Book not found.");
        }

        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            DoublyNode temp = head;
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Next;
            }
        }

        // Display reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }

            DoublyNode temp = tail;
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Previous;
            }
        }

        // Count books
        public void CountBooks()
        {
            int count = 0;
            DoublyNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            Console.WriteLine($"Total number of books: {count}");
        }
    }
}
