namespace BridgeLabzTraining.dsa_csharp_practice.library_management_system
{
    class DoublyNode
    {
        public Book Data;
        public DoublyNode Next;
        public DoublyNode Previous;

        public DoublyNode(Book book)
        {
            Data = book;
            Next = null;
            Previous = null;
        }
    }
}
