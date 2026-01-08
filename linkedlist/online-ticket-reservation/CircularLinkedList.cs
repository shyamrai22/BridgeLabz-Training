using System;

namespace BridgeLabzTraining.dsa_csharp_practice.online_ticket_reservation
{
    class CircularLinkedList
    {
        private CircularNode head;

        // Add ticket at end
        public void AddTicket(Ticket ticket)
        {
            CircularNode newNode = new CircularNode(ticket);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            CircularNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Remove ticket by ticketId
        public void RemoveTicket(int ticketId)
        {
            if (head == null)
            {
                Console.WriteLine("Not available.");
                return;
            }

            CircularNode temp = head;
            CircularNode prev = null;

            do
            {
                if (temp.Data.TicketId == ticketId)
                {
                    if (temp == head)
                    {
                        CircularNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = temp.Next;
                    }

                    Console.WriteLine("Removed successfully.");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Not found.");
        }

        // Display
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No ticket booked.");
                return;
            }

            CircularNode temp = head;
            do
            {
                temp.Data.Display();
                temp = temp.Next;
            } while (temp != head);
        }

        // Search by Customer Name
        public void SearchByCustomer(string name)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            CircularNode temp = head;
            bool found = false;

            do
            {
                if (temp.Data.CustomerName.Equals(name))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No ticket found");
        }

        // Search by Movie Name
        public void SearchByMovie(string movie)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            CircularNode temp = head;
            bool found = false;

            do
            {
                if (temp.Data.MovieName.Equals(movie))
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tickets found for this movie.");
        }

        // Total tickets
        public void CountTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Tickets --> 0");
                return;
            }

            int count = 0;
            CircularNode temp = head;

            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine($"Total Tickets Booked --> {count}");
        }
    }
}
