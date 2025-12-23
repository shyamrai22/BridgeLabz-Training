using System;

class Grade 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a marks of physics : ");
		double phy = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter a marks of chemistry : ");
		double chem = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter a marks of maths : ");
		double math = Convert.ToDouble(Console.ReadLine());
		
		double avg = (math + phy + chem) / 3; 
		
		if(avg >= 80)
		{
			Console.WriteLine($"Average Marks : {avg:F2}, Grade : A, Level 4, above agency-normalized standards.");
		}
		
		else if(avg >= 70 && avg < 80)
		{
			Console.WriteLine($"Average Marks : {avg:F2}, Grade : B, Level 3, at agency-normalized standards.");
		}
		
		else if(avg >= 60 && avg < 70)
		{
			Console.WriteLine($"Average Marks : {avg:F2}, Grade : C, Level 2, below, but approaching at agency-normalized standards.");
		}
		
		else if(avg >= 50 && avg < 60)
		{
			Console.WriteLine($"Average Marks : {avg:F2}, Grade : D, Level 1, well below agency-normalized standards.");
		}
		
		else if(avg >= 40 && avg < 50)
		{
			Console.WriteLine($"Average Marks : {avg:F2}, Grade : E, Level 1-, too below agency-normalized standards.");
		}
		
		else
		{
			Console.WriteLine($"Average Marks : {avg:F2}, Grade : F, Remedial Standards");
		}		
	}
}