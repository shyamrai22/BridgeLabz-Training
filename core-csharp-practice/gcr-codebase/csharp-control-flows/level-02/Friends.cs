using System;

class Friends 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter Amar's age : ");
		double amar_a = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Amar's height : ");
		double amar_h = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter Akbar's age : ");
		double akbar_a = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Akbar's height : ");
		double akbar_h = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter Anthony's age : ");
		double anthony_a = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter Anthony's height : ");
		double anthony_h = Convert.ToDouble(Console.ReadLine());
		
		
		if(amar_a < anthony_a && amar_a < akbar_a) 
		{
			Console.WriteLine("Youngest is Amar");
		}
		
		else if(akbar_a < anthony_a && akbar_a < amar_a) 
		{
			Console.WriteLine("Youngest is Akbar");
		}
		
		else 
		{
			Console.WriteLine("Youngest is Anthony");
		}
		
		
		
		if(amar_h > anthony_h && amar_h < akbar_h) 
		{
			Console.WriteLine("Tallest is Amar");
		}
		
		else if(akbar_h > anthony_h && akbar_h > amar_h) 
		{
			Console.WriteLine("Tallest is Akbar");
		}
		
		else 
		{
			Console.WriteLine("Tallest is Anthony");
		}
	}
}