using System;

class VolumeOfCylinder {
	
	public static void Main(string[] args) {
		
		Console.Write("Enter the radius of the cylinder: ");
		double radius = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the height of the cylinder: ");
		double height = Convert.ToDouble(Console.ReadLine());
		
		double vol = 22/7 * (radius * radius) * height;
		Console.Write("Volume of cylinder : " + vol);
		
	}
}