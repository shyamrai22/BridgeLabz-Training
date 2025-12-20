using System;

class SwapNumbers  {

    static void Main(string[] args) {
	
        Console.Write("Enter number1 : ");
        int number1 = int.Parse(Console.ReadLine());
		Console.Write("Enter number1 : ");
		int number2 = int.Parse(Console.ReadLine());
		
		int temp = number1;
		number1 = number2;
		number2 = temp;
			
		Console.WriteLine($"The swapped numbers are {number1} and {number2}");
		
    }
}
