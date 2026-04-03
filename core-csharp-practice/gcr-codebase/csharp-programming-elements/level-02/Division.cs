using System;

class Division{

    static void Main(string[] args) {
	
        Console.Write("Enter the number1 : ");
        double number1  = double.Parse(Console.ReadLine());
		
		Console.Write("Enter the number2 : ");
        double number2  = double.Parse(Console.ReadLine());			
		
		Console.WriteLine($"The Quotient is {(int)(number1 / number2)} and Remainder is {number1 % number2} of two numbers {number1} and {number2}.");
		
    }
}
