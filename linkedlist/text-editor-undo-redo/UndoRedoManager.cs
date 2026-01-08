using System;

namespace BridgeLabzTraining.dsa_csharp_practice.undo_redo_text_editor
{
    class UndoRedoManager
    {
        private DoublyNode head;
        private DoublyNode current;
        private int count;
        private readonly int maxSize = 10;

        // Add new text state
        public void AddState(string content)
        {
            TextState state = new TextState(content);
            DoublyNode newNode = new DoublyNode(state);

            if (current != null && current.Next != null)
            {
                current.Next.Previous = null;
                current.Next = null;
            }

            if (head == null)
            {
                head = current = newNode;
                count = 1;
                return;
            }

            current.Next = newNode;
            newNode.Previous = current;
            current = newNode;
            count++;

            if (count > maxSize)
            {
                head = head.Next;
                head.Previous = null;
                count--;
            }
        }

        // Undo
        public void Undo()
        {
            if (current == null || current.Previous == null)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }

            current = current.Previous;
        }

        // Redo
        public void Redo()
        {
            if (current == null || current.Next == null)
            {
                Console.WriteLine("Nothing to redo.");
                return;
            }

            current = current.Next;
        }

        // Display
        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("Empty.");
                return;
            }

            Console.WriteLine($"Current Text --> {current.Data.Content}");
        }
    }
}
