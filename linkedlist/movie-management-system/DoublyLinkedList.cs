using System;

namespace BridgeLabzTraining.dsa_csharp_practice.movie_management_system
{
    class DoublyLinkedList
    {
        private DoublyNode head;
        private DoublyNode tail;

        // Add at beginning
        public void AddAtBeginning(Movie movie)
        {
            DoublyNode newNode = new DoublyNode(movie);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(Movie movie)
        {
            DoublyNode newNode = new DoublyNode(movie);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        // Add at position (1-based)
        public void AddAtPosition(Movie movie, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(movie);
                return;
            }

            DoublyNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null || temp.Next == null)
            {
                AddAtEnd(movie);
                return;
            }

            DoublyNode newNode = new DoublyNode(movie);
            newNode.Next = temp.Next;
            newNode.Previous = temp;
            temp.Next.Previous = newNode;
            temp.Next = newNode;
        }

        // Remove by Movie Title
        public void RemoveByTitle(string title)
        {
            DoublyNode temp = head;

            while (temp != null)
            {
                if (temp.Data.Title.Equals(title))
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

                    Console.WriteLine("Movie removed successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Search by Director
        public void SearchByDirector(string director)
        {
            DoublyNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Data.Director.Equals(director))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found for this director.");
        }

        // Search by Rating
        public void SearchByRating(double rating)
        {
            DoublyNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Data.Rating == rating)
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No movies found with this rating.");
        }

        // Update Rating by Title
        public void UpdateRating(string title, double newRating)
        {
            DoublyNode temp = head;

            while (temp != null)
            {
                if (temp.Data.Title.Equals(title))
                {
                    temp.Data.Rating = newRating;
                    Console.WriteLine("Rating updated successfully.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found.");
        }

        // Display forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("No movies available.");
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
                Console.WriteLine("No movies available.");
                return;
            }

            DoublyNode temp = tail;
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Previous;
            }
        }
    }
}
