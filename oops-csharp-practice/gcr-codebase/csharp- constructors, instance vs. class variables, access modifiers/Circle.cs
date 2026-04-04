using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Circle
    {
        private double radius;

        // default constructor
        public Circle() : this(1.0) { }

        // parameterised constructor/core constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // method to display fields
        public void Display()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Radius --> {radius}");
            Console.WriteLine("===================");
        }
    }

    // class with main method
    class Caller
    {
        public static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(5.0);

            circle1.Display();
            circle2.Display();
        }
    }
}
