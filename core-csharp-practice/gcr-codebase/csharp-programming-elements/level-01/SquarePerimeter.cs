using System;

class SquarePerimeter{

    static void Main(string[] args) {
	
        Console.Write("Enter perimeter of the square : ");
        double per = double.Parse(Console.ReadLine());
		
		double side = per / 4;
        Console.WriteLine($"The length of the side is {side} whose perimeter is {per}.");
		
    }
}
