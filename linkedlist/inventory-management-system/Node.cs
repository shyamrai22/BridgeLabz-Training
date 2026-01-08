namespace BridgeLabzTraining.dsa_csharp_practice.inventory_management_system
{
    class Node
    {
        public Item Data;
        public Node Next;

        public Node(Item item)
        {
            Data = item;
            Next = null;
        }
    }
}
