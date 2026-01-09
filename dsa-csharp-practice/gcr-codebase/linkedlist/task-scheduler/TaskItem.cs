using System;

namespace BridgeLabzTraining.dsa_csharp_practice.task_scheduler
{
    class TaskItem
    {
        private int taskId;
        private string taskName;
        private int priority;
        private string dueDate;

        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public TaskItem(int taskId, string taskName, int priority, string dueDate)
        {
            this.taskId = taskId;
            this.taskName = taskName;
            this.priority = priority;
            this.dueDate = dueDate;
        }

        public void Display()
        {
            Console.WriteLine(
                $"ID: {TaskId}, Name: {TaskName}, Priority: {Priority}, Due: {DueDate}"
            );
        }
    }
}
