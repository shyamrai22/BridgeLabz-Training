using System;

class TemperatureConversion  {

    static void Main(string[] args) {
	
        Console.Write("Enter the temperature in celsius : ");
        double celsius = double.Parse(Console.ReadLine());
		double fahrenheit = (celsius * 9.0/5.0) + 32;
			
		Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
		
    }
}
