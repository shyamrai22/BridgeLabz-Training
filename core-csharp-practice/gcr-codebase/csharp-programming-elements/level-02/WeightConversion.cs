using System;

class WeightConversion {

    static void Main(string[] args) {
	
        Console.Write("Enter weight in pounds: ");
        double pound = double.Parse(Console.ReadLine());

        double kilogram = pound / 2.2;

        Console.WriteLine($"The weight of the person in pounds is {pound} and in kg is {kilogram:F2}");
    }
}
