using System;

namespace BridgeLabzTraining.dsa_csharp_practice.student_record_management
{
    class Caller
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            int choice;

            do
            {
                Console.WriteLine("--- Student Record Management ---");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Delete by Roll Number");
                Console.WriteLine("5. Search by Roll Number");
                Console.WriteLine("6. Update Grade");
                Console.WriteLine("7. Display All");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Roll Number: ");
                        int roll1 = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name1 = Console.ReadLine();
                        Console.Write("Age: ");
                        int age1 = int.Parse(Console.ReadLine());
                        Console.Write("Grade: ");
                        char grade1 = char.Parse(Console.ReadLine());

                        Student student1 = new Student(roll1, name1, age1, grade1);
                        list.AddAtBeginning(student1);
                        break;

                    case 2:
                        Console.Write("Roll Number: ");
                        int roll2 = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name2 = Console.ReadLine();
                        Console.Write("Age: ");
                        int age2 = int.Parse(Console.ReadLine());
                        Console.Write("Grade: ");
                        char grade2 = char.Parse(Console.ReadLine());

                        Student student2 = new Student(roll2, name2, age2, grade2);
                        list.AddAtEnd(student2);
                        break;

                    case 3:
                        Console.Write("Roll Number: ");
                        int roll3 = int.Parse(Console.ReadLine());
                        Console.Write("Name: ");
                        string name3 = Console.ReadLine();
                        Console.Write("Age: ");
                        int age3 = int.Parse(Console.ReadLine());
                        Console.Write("Grade: ");
                        char grade3 = char.Parse(Console.ReadLine());

                        Console.Write("Position: ");
                        int pos = int.Parse(Console.ReadLine());

                        Student student3 = new Student(roll3, name3, age3, grade3);
                        list.AddAtPosition(student3, pos);
                        break;

                    case 4:
                        Console.Write("Enter Roll Number: ");
                        list.DeleteByRollNumber(int.Parse(Console.ReadLine()));
                        break;

                    case 5:
                        Console.Write("Enter Roll Number: ");
                        list.Search(int.Parse(Console.ReadLine()));
                        break;

                    case 6:
                        Console.Write("Enter Roll Number: ");
                        int r = int.Parse(Console.ReadLine());
                        Console.Write("Enter new Grade: ");
                        char g = char.Parse(Console.ReadLine());
                        list.UpdateGrade(r, g);
                        break;

                    case 7:
                        list.DisplayAll();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
