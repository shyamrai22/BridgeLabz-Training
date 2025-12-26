using System;

public class ZeroesArranged 
{
	public static void Main(string[] args) 
	{
		Console.Write("Enter the length of array : ");
		int n = int.Parse(Console.ReadLine());
		int[] num = new int[n];
		int[] res = new int[n];
		
		for(int i=0; i<n; i++) 
		{
			num[i] = int.Parse(Console.ReadLine());
		}
		int start = 0;
		int end = n-1;
		
		for(int i=0; i<n; i++) 
		{
			if(num[i] == 0)
				res[end--] = num[i];
				
			else if(num[i] > 0) 
				res[start++] = num[i];
				
		}
		
		for(int i=0; i<n; i++) 
		{
			Console.Write(res[i] + " ");
		}
	}
}