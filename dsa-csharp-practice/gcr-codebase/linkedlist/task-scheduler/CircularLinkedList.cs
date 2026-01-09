using System;

namespace BridgeLabzTraining.dsa_csharp_practice.task_scheduler
{
    class CircularLinkedList
    {
        private CircularNode head;
        private CircularNode current;

        // Add at beginning
        public void AddAtBeginning(TaskItem task)
        {
            CircularNode newNode = new CircularNode(task);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                return;
            }

            CircularNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(TaskItem task)
        {
            CircularNode newNode = new CircularNode(task);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                current = head;
                return;
            }

            CircularNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Add at position (1-based)
        public void AddAtPosition(TaskItem task, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(task);
                return;
            }

            CircularNode temp = head;
            for (int i = 1; i < position - 1 && temp.Next != head; i++)
            {
                temp = temp.Next;
            }

            CircularNode newNode = new CircularNode(task);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Remove by Task ID
        public void RemoveByTaskId(int taskId)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            CircularNode temp = head;
            CircularNode prev = null;

            do
            {
                if (temp.Data.TaskId == taskId)
                {
                    if (temp == head)
                    {
                        CircularNode last = head;
                        while (last.Next != head)
                        {
                            last = last.Next;
                        }

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = temp.Next;
                    }

                    Console.WriteLine("Task removed successfully.");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Task not found.");
        }

        // View current task and move to next
        public void ViewCurrentAndMoveNext()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Current Task:");
            current.Data.Display();
            current = current.Next;
        }

        // Display all tasks
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            CircularNode temp = head;
            do
            {
                temp.Data.Display();
                temp = temp.Next;
            } while (temp != head);
        }

        // Search by Priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            CircularNode temp = head;
            bool found = false;

            do
            {
                if (temp.Data.Priority == priority)
                {
                    temp.Data.Display();
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tasks found with this priority.");
        }
    }
}
