namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    interface IEntryQueue
    {
        void Enqueue(string vehicleId);
        string Dequeue();
        bool isFull();
        bool isEmpty();
        void DisplayQueue();
    }
}
