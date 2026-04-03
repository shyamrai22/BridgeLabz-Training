using System;

class PerimeterOfRectangle {
	
	public static void Main(string[] args) {
		
		Console.Write("Enter the length of the rectangle: ");
		double length = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the breadth of the rectangle: ");
		double breadth = Convert.ToDouble(Console.ReadLine());
		
		double per = 2 * (length + breadth);
		Console.Write("Perimeter of rectangle : " + per);
		
	}
}