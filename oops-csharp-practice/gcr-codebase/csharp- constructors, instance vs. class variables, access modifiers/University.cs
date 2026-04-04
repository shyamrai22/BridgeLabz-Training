using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class University
    {
        // public 
        public int rollNumber;
        // protected 
        protected string name;
        // private 
        private double CGPA;

        // constructor
        public University(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.CGPA = cgpa;
        }

        // Method to access CGPA
        public double GetCGPA()
        {
            return CGPA;
        }

        // Method to modify CGPA
        public void SetCGPA(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 10)
            {
                CGPA = cgpa;
            }
            else
            {
                Console.WriteLine("Invalid CGPA value");
            }
        }
    }

    // protected access
    class PostgraduateStudent : University
    {
        private string specialization;

        public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
            : base(rollNumber, name, cgpa)
        {
            this.specialization = specialization;
        }

        public void DisplayPostgraduateDetails()
        {
            Console.WriteLine("============================");
            Console.WriteLine($"Roll Number    --> {rollNumber}");
            Console.WriteLine($"Name           --> {name}");
            Console.WriteLine($"Specialization --> {specialization}");
            Console.WriteLine($"CGPA           --> {GetCGPA()}");
            Console.WriteLine("============================");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            PostgraduateStudent pg =
                new PostgraduateStudent(101, "Shyam", 8.3, "AIML");

            pg.DisplayPostgraduateDetails();
            pg.SetCGPA(9.2);

            Console.WriteLine("Updated CGPA --> " + pg.GetCGPA());
        }
    }
}
