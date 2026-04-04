using System;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    class EntryQueueUtility: IEntryQueue
    {
        private string[] queue;
        private int front;
        private int rear;
        private int size;
        private int capacity;

        public EntryQueueUtility(int capacity)
        {
            this.capacity = capacity;
            queue = new string[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool isFull()
        {
            if(size == capacity)
            {
                return true;
            }
            return false;
        }

        public bool isEmpty()
        {
            if(size == 0)
            {
                return true;
            }
            return false;
        }

        public void Enqueue(string vehicleId)
        {
            if(isFull())
            {
                Console.WriteLine("Queue full, no vehicle can be added");
                return;
            }
            rear = (rear + 1) % capacity;
            queue[rear] = vehicleId;
            size++;
            Console.WriteLine($"Vehicle {vehicleId} is added to the queue");
        }

        public string Dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return null;
            }
            string vehicleId = queue[front];
            front = (front + 1) % capacity;
            size--;

            return vehicleId;
        }

        public void DisplayQueue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            for(int i=0; i<size; i++)
            {
                Console.Write($"{queue[(front+i)%capacity]} <- ");
            }
        }
    }
}
