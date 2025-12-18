using System;

class TemperatureConverter {

	public static void Main(string[] args) {
	
		Console.Write("Enter temperature in celsius : ");
		decimal cel = Convert.ToDecimal(Console.ReadLine());
		decimal fah = (cel * 9m/5m) + 32m;
		
		Console.Write("Temperature in Fahrenheit :" + fah);
	
	}
}