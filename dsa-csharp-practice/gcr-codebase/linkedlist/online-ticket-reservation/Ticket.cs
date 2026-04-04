using System;

namespace BridgeLabzTraining.dsa_csharp_practice.online_ticket_reservation
{
    class Ticket
    {
        private int ticketId;
        private string customerName;
        private string movieName;
        private string seatNumber;
        private string bookingTime;

        public int TicketId
        {
            get { return ticketId; }
            set { ticketId = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        public string SeatNumber
        {
            get { return seatNumber; }
            set { seatNumber = value; }
        }

        public string BookingTime
        {
            get { return bookingTime; }
            set { bookingTime = value; }
        }

        public Ticket(int ticketId, string customerName, string movieName,
                      string seatNumber, string bookingTime)
        {
            this.ticketId = ticketId;
            this.customerName = customerName;
            this.movieName = movieName;
            this.seatNumber = seatNumber;
            this.bookingTime = bookingTime;
        }

        public void Display()
        {
            Console.WriteLine(
                $"TicketID: {TicketId}" +
                $" Customer: {CustomerName}" +
                $" Movie: {MovieName}" +
                $" Seat: {SeatNumber}" +
                $" Time: {BookingTime}"
            );
        }
    }
}
