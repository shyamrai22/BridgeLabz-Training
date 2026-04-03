using System;

class Bmi 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter weight : ");
		double w = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter height : ");
		double h = Convert.ToDouble(Console.ReadLine());
		double hInMeter = h / 100.0;
		
		double bmi = w / (hInMeter * hInMeter);
		
		if(bmi >= 40.0) 
		{
			Console.WriteLine("Obese");
		}
		
		else if(bmi >= 25.0 && bmi <= 39.9) 
		{
			Console.WriteLine("Overweight");
		}
		
		else if(bmi >= 18.5 && bmi <= 24.9) 
		{
			Console.WriteLine("Normal");
		}
		
		else 
		{
			Console.WriteLine("Underweight");
		}
	}
}