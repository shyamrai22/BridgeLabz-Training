namespace BridgeLabzTraining.dsa_csharp_practice.round_robin_scheduler
{
    class CircularNode
    {
        public Process Data;
        public CircularNode Next;

        public CircularNode(Process process)
        {
            Data = process;
            Next = null;
        }
    }
}
