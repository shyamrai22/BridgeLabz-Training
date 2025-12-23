using System;

class Armstrong 
{
	static void Main(string[] args)
	{
		
		Console.Write("Enter a number : ");
		string numStr = Console.ReadLine();
		int exp = numStr.Length;
		int num = Convert.ToInt32(numStr);
		int temp = num;
		int sum = 0;
		int dig = 0;
				
		while(temp != 0) 
		{
			dig = temp % 10;
			sum += (int)Math.Pow(dig,exp); 
			temp = temp / 10;
		}
		
		if(sum == num) 
		{
			Console.WriteLine("Armstrong number");
		}
		else 
		{
			Console.WriteLine("Not a armstrong number");
		}
		
	}
}