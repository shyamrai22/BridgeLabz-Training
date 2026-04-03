using System;

class LengthOfNumber 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		int num = Convert.ToInt32(Console.ReadLine());
		string numStr = Convert.ToString(num);
		
		Console.WriteLine(numStr.Length);
        		
	}
}