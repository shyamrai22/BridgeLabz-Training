using System;

class AreaOfCircle {
	
	public static void Main(string[] args) {
		
		Console.Write("Enter the radius of the circle: ");
		double radius = Convert.ToDouble(Console.ReadLine());
		double area = 22/7 * Math.Pow(radius,2);
		
		Console.WriteLine("Area of Circle : " + area);
		
	}
}