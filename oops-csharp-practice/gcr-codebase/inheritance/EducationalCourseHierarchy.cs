using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Base class
    class Course
    {
        public string CourseName;
        public int Duration; 

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        // Virtual method
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Course Name --> {CourseName}");
            Console.WriteLine($"Duration    --> {Duration} weeks");
        }
    }

    // Subclass lvl-1
    class OnlineCourse : Course
    {
        public string Platform;
        public bool IsRecorded;

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Online Course");
            base.DisplayDetails();
            Console.WriteLine($"Platform    --> {Platform}");
            Console.WriteLine($"Recorded    --> {IsRecorded}");
        }
    }

    // Subclass lvl-02
    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;
        public double Discount;

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Paid Online Course");
            base.DisplayDetails();
            Console.WriteLine($"Fee        --> {Fee}");
            Console.WriteLine($"Discount   --> {Discount}%");
            Console.WriteLine($"Final Fee  --> {Fee - (Fee * Discount / 100)}");
            Console.WriteLine("--------------------------------");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Course course1 = new Course("Programming", 6);
            Course course2 = new OnlineCourse("C# Fundamentals", 7, "Coursera", true);
            Course course3 = new PaidOnlineCourse("Full Stack Development", 12, "Coursera", true, 50000, 20);

            course1.DisplayDetails();
            Console.WriteLine();
            course2.DisplayDetails();
            Console.WriteLine();
            course3.DisplayDetails();
        }
    }
}
