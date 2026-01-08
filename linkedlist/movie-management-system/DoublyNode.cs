namespace BridgeLabzTraining.dsa_csharp_practice.movie_management_system
{
    class DoublyNode
    {
        public Movie Data;
        public DoublyNode Next;
        public DoublyNode Previous;

        public DoublyNode(Movie movie)
        {
            Data = movie;
            Next = null;
            Previous = null;
        }
    }
}
