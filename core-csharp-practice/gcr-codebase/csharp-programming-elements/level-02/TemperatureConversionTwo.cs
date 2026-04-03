using System;

class TemperatureConversionTwo  {

    static void Main(string[] args) {
	
        Console.Write("Enter the temperature in fahrenheit : ");
        double fahrenheit = double.Parse(Console.ReadLine());
		double celsius =  (fahrenheit - 32) * 5.0/9.0;
			
		Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius} Celsius");
		
    }
}
