using System;

namespace BridgeLabzTraining.dsa_csharp_practice.student_record_management
{
    class Student
    {
        private int rollNumber;
        private string name;
        private int age;
        private char grade;

        public int RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public char Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(int rollNumber, string name, int age, char grade)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Roll No: {RollNumber}, Name: {Name}, Age: {Age}, Grade: {Grade}"
            );
        }
    }
}
