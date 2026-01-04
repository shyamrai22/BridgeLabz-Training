using System;

namespace BridgeLabzTraining.oops_csharp_practice.this__sealed__static_key_words_and_is_operator
{
    class Student
    {
        public static string UniversityName = "GLA University";
        private static int totalStudents = 0;
        public readonly int RollNumber;

        // instance variables
        public string Name;
        public string Grade;

        // using 'this' keyword
        public Student(int rollNumber, string name, string grade)
        {
            this.RollNumber = rollNumber;
            this.Name = name;
            this.Grade = grade;
            totalStudents++;
        }

        // static method
        public static void DisplayTotal()
        {
            Console.WriteLine($"Total Students --> {totalStudents}");
        }

        // using 'is' operator
        public void DisplayDetails(object obj)
        {
            if (obj is Student)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"University  --> {UniversityName}");
                Console.WriteLine($"Roll Number --> {RollNumber}");
                Console.WriteLine($"Name        --> {Name}");
                Console.WriteLine($"Grade       --> {Grade}");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("Object is not a Student");
            }
        }

        // method to update grade
        public void UpdateGrade(object obj, string newGrade)
        {
            if (obj is Student)
            {
                this.Grade = newGrade;
                Console.WriteLine("Grade updated");
            }
            else
            {
                Console.WriteLine("Invalid object.");
            }
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(101, "Shyam", "A");
            Student s2 = new Student(102, "Daman", "B");

            s1.DisplayDetails(s1);
            s2.DisplayDetails(s2);

            Student.DisplayTotal();

            s1.UpdateGrade(s1, "A+");
            s1.DisplayDetails(s1);

            object obj = "Not a student";
            s1.DisplayDetails(obj);
        }
    }
}
