using System;

class KmToMiles {

	public static void Main(string[] args) {
	
		Console.Write("Enter distance in km : ");
		decimal km = Convert.ToDecimal(Console.ReadLine());
		decimal miles = km * 0.621371m;
		
		Console.Write("Distance in Miles :" + miles);
	
	}
}