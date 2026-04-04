namespace BridgeLabzTraining.dsa_csharp_practice.social_media_friend_connections
{
    class Node
    {
        public User Data;
        public Node Next;

        public Node(User user)
        {
            Data = user;
            Next = null;
        }
    }
}
