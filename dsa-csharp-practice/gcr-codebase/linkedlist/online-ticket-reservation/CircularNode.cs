namespace BridgeLabzTraining.dsa_csharp_practice.online_ticket_reservation
{
    class CircularNode
    {
        public Ticket Data;
        public CircularNode Next;

        public CircularNode(Ticket ticket)
        {
            Data = ticket;
            Next = null;
        }
    }
}
