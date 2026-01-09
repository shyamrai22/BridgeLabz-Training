using System;

namespace BridgeLabzTraining.dsa_csharp_practice.round_robin_scheduler
{
    class CircularLinkedList
    {
        private CircularNode head;
        private CircularNode tail;

        public void AddProcess(Process process)
        {
            CircularNode newNode = new CircularNode(process);

            if (head == null)
            {
                head = tail = newNode;
                newNode.Next = head;
                return;
            }

            tail.Next = newNode;
            newNode.Next = head;
            tail = newNode;
        }

        public void RemoveProcess(int processId)
        {
            if (head == null)
                return;

            CircularNode current = head;
            CircularNode prev = tail;

            do
            {
                if (current.Data.ProcessId == processId)
                {
                    if (current == head)
                        head = head.Next;

                    prev.Next = current.Next;

                    if (current == tail)
                        tail = prev;

                    if (head == tail && head.Data.ProcessId == processId)
                    {
                        head = tail = null;
                    }

                    return;
                }

                prev = current;
                current = current.Next;

            } while (current != head);
        }

        public void Simulate(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes available.");
                return;
            }

            int currentTime = 0;
            int completed = 0;
            int totalProcesses = CountProcesses();

            CircularNode current = head;

            while (completed < totalProcesses)
            {
                if (current.Data.RemainingTime > 0)
                {
                    Console.WriteLine($"Executing Process {current.Data.ProcessId}");

                    if (current.Data.RemainingTime > timeQuantum)
                    {
                        current.Data.RemainingTime -= timeQuantum;
                        currentTime += timeQuantum;
                    }
                    else
                    {
                        currentTime += current.Data.RemainingTime;
                        current.Data.RemainingTime = 0;
                        current.Data.TurnAroundTime = currentTime;
                        completed++;
                    }

                    UpdateWaitingTime(current, timeQuantum);
                    DisplayQueue();
                }

                current = current.Next;
            }

            CalculateAverages(totalProcesses);
        }

        private void UpdateWaitingTime(CircularNode executingNode, int timeQuantum)
        {
            CircularNode temp = head;

            do
            {
                if (temp != executingNode && temp.Data.RemainingTime > 0)
                {
                    temp.Data.WaitingTime +=
                        Math.Min(timeQuantum, executingNode.Data.BurstTime);
                }
                temp = temp.Next;
            } while (temp != head);
        }

        public void DisplayQueue()
        {
            if (head == null)
                return;

            Console.WriteLine("Current Queue:");
            CircularNode temp = head;

            do
            {
                temp.Data.Display();
                temp = temp.Next;
            } while (temp != head);
        }

        private int CountProcesses()
        {
            if (head == null)
                return 0;

            int count = 0;
            CircularNode temp = head;

            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }

        private void CalculateAverages(int total)
        {
            double totalWT = 0, totalTAT = 0;
            CircularNode temp = head;

            do
            {
                totalWT += temp.Data.WaitingTime;
                totalTAT += temp.Data.TurnAroundTime;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine($"Avg Waiting Time --> {totalWT / total}");
            Console.WriteLine($"Avg Turnaround Time --> {totalTAT / total}");
        }
    }
}
