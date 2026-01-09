using System;

namespace BridgeLabzTraining.dsa_csharp_practice.online_ticket_reservation
{
    class Caller
    {
        public static void Main(string[] args)
        {
            CircularLinkedList ticket = new CircularLinkedList();
            int choice;

            do
            {
                Console.WriteLine("Online Ticket Reservation");
                Console.WriteLine("1. Add Ticket");
                Console.WriteLine("2. Remove Ticket");
                Console.WriteLine("3. Display Tickets");
                Console.WriteLine("4. Search by Customer Name");
                Console.WriteLine("5. Search by Movie Name");
                Console.WriteLine("6. Count Tickets");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Ticket ID --> ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Customer Name --> ");
                        string cusName = Console.ReadLine();
                        Console.Write("Movie Name --> ");
                        string movName = Console.ReadLine();
                        Console.Write("Seat Number --> ");
                        string seat = Console.ReadLine();
                        Console.Write("Booking Time --> ");
                        string time = Console.ReadLine();

                        ticket.AddTicket(new Ticket(id, cusName, movName, seat, time));
                        break;

                    case 2:
                        Console.Write("Ticket ID --> ");
                        ticket.RemoveTicket(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        ticket.DisplayTickets();
                        break;

                    case 4:
                        Console.Write("Customer Name --> ");
                        ticket.SearchByCustomer(Console.ReadLine());
                        break;

                    case 5:
                        Console.Write("Movie Name --> ");
                        ticket.SearchByMovie(Console.ReadLine());
                        break;

                    case 6:
                        ticket.CountTickets();
                        break;

                    case 0:
                        Console.WriteLine("exiting....");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
