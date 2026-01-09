using System;

namespace BridgeLabzTraining.dsa_csharp_practice.round_robin_scheduler
{
    class Process
    {
        private int processId;
        private int burstTime;
        private int priority;

        public int RemainingTime;
        public int WaitingTime;
        public int TurnAroundTime;

        public int ProcessId
        {
            get { return processId; }
            set { processId = value; }
        }

        public int BurstTime
        {
            get { return burstTime; }
            set { burstTime = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public Process(int processId, int burstTime, int priority)
        {
            this.processId = processId;
            this.burstTime = burstTime;
            this.priority = priority;

            RemainingTime = burstTime;
            WaitingTime = 0;
            TurnAroundTime = 0;
        }

        public void Display()
        {
            Console.WriteLine(
                $"PID: {ProcessId}" +
                $" Burst: {BurstTime}" +
                $" Remaining: {RemainingTime}" +
                $" Priority: {Priority}"
            );
        }
    }
}
