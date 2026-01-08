using System;

namespace BridgeLabzTraining.dsa_csharp_practice.student_record_management
{
    class SinglyLinkedList
    {
        private Node head;

        // Add at beginning
        public void AddAtBeginning(Student student)
        {
            Node newNode = new Node(student);
            newNode.Next = head;
            head = newNode;
        }

        // Add at end
        public void AddAtEnd(Student student)
        {
            Node newNode = new Node(student);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        // Add at specific position (1-based index)
        public void AddAtPosition(Student student, int position)
        {
            if (position <= 1)
            {
                AddAtBeginning(student);
                return;
            }

            Node temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            Node newNode = new Node(student);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Delete by Roll Number
        public void DeleteByRollNumber(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.Data.RollNumber == rollNumber)
            {
                head = head.Next;
                Console.WriteLine("Student deleted successfully.");
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Data.RollNumber != rollNumber)
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Student deleted successfully.");
        }

        // Search by Roll Number
        public void Search(int rollNumber)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.RollNumber == rollNumber)
                {
                    Console.WriteLine("Student found:");
                    temp.Data.Display();
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");
        }

        // Update Grade
        public void UpdateGrade(int rollNumber, char newGrade)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Data.RollNumber == rollNumber)
                {
                    temp.Data.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found.");
        }

        // Display all students
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available.");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                temp.Data.Display();
                temp = temp.Next;
            }
        }
    }
}
