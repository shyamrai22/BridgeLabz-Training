using System;

class HeightConverter
{
    static void Main(string[] args)
    {
        Console.Write("Enter your height in centimeters: ");
		
        double heightCm = double.Parse(Console.ReadLine());
        double Inches = heightCm / 2.54;
        int feet = (int)(Inches / 12);
        double inches = Inches % 12;

        Console.WriteLine(
            $"Your Height in cm is {heightCm} while in feet is {feet} and inches is {inches:F2}"
        );
    }
}
