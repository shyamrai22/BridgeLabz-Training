using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Superclass
    class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Virtual method
        public virtual void DisplayRole()
        {
            Console.WriteLine("Role --> Person");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name --> {Name}");
            Console.WriteLine($"Age --> {Age}");
        }
    }

    // Teacher
    class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role --> Teacher");
            DisplayInfo();
            Console.WriteLine($"Subject --> {Subject}");
            Console.WriteLine("--------------------------------");
        }
    }

    // Student
    class Student : Person
    {
        public string Grade;

        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role --> Student");
            DisplayInfo();
            Console.WriteLine($"Grade --> {Grade}");
            Console.WriteLine("--------------------------------");
        }
    }

    // Staff
    class Staff : Person
    {
        public string Department;

        public Staff(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role --> Staff");
            DisplayInfo();
            Console.WriteLine($"Department --> {Department}");
            Console.WriteLine("--------------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Person[] peoples =
            {
                new Teacher("Shyam", 30, "Mathematics"),
                new Student("Daman", 16, "10th Grade"),
                new Staff("Sambhav", 40, "Administration")
            };

            foreach (Person people in peoples)
            {
                people.DisplayRole();
            }
        }
    }
}
