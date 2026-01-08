namespace BridgeLabzTraining.dsa_csharp_practice.task_scheduler
{
    class CircularNode
    {
        public TaskItem Data;
        public CircularNode Next;

        public CircularNode(TaskItem task)
        {
            Data = task;
            Next = null;
        }
    }
}
