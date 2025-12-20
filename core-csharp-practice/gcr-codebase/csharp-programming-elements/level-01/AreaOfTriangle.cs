using System;

class AreaOfTriangle{

    static void Main(string[] args) {
	
        Console.Write("Enter base of the triangle : ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter height of the triangle : ");
        double height = double.Parse(Console.ReadLine());
		
		double area = 0.5 * b * height;
        Console.WriteLine($"Area of the triangle : {area}");
		
    }
}
