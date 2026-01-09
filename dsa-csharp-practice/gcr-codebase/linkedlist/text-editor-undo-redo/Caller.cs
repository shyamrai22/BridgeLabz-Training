using System;

namespace BridgeLabzTraining.dsa_csharp_practice.undo_redo_text_editor
{
    class Caller
    {
        public static void Main(string[] args)
        {
            UndoRedoManager editor = new UndoRedoManager();
            int choice;

            do
            {
                Console.WriteLine("Text Editor (Undo / Redo)");
                Console.WriteLine("1. Type / Add Text");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Display Current Text");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text -->  ");
                        string text = Console.ReadLine();
                        editor.AddState(text);
                        break;

                    case 2:
                        editor.Undo();
                        break;

                    case 3:
                        editor.Redo();
                        break;

                    case 4:
                        editor.DisplayCurrentState();
                        break;

                    case 0:
                        Console.WriteLine("exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
