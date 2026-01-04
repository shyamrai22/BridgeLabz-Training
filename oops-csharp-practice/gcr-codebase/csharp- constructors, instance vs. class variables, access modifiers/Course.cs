using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Course
    {
        // instance variables
        private string courseName;
        private int duration;
        private double fee;

        // class variable
        private static string instituteName = "BridgeLabz";

        // parameterized constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        // instance method
        public void DisplayDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Institute Name --> {instituteName}");
            Console.WriteLine($"Course Name    --> {courseName}");
            Console.WriteLine($"Duration       --> {duration} weeks");
            Console.WriteLine($"Fee            --> {fee}");
            Console.WriteLine("------------------------------");
        }

        // class method
        public static void UpdateInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Course course1 = new Course("C# Programming", 10, 2500);
            Course course2 = new Course(".Net Development", 14, 6000);
            course1.DisplayDetails();
            course2.DisplayDetails();

            Course.UpdateInstituteName("GLA");

            course1.DisplayDetails();
            course2.DisplayDetails();
        }
    }
}
