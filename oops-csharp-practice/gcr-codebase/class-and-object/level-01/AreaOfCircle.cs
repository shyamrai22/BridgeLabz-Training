using System;

namespace BridgeLabzTraining.oops_csharp_practice.class_and_object
{
    internal class AreaOfCircle
    {
        private double radius;
        public void Display()
        {
            AreaOfCircle cir = new AreaOfCircle();
            Console.Write("Enter radius of circle: ");

            cir.radius = Convert.ToDouble(Console.ReadLine());

            cir.CalculateArea();
            cir.CalculateCircumference();
        }

        public void CalculateArea()
        {
            double areaOfCircle = Math.PI * radius * radius;
            Console.WriteLine("Area of the Circle: " + areaOfCircle);
        }

        public void CalculateCircumference()
        {
            double circumferenceOfCircle = 2 * Math.PI * radius;
            Console.WriteLine("Circumference of the Circle: " + circumferenceOfCircle);
        }

    }
}