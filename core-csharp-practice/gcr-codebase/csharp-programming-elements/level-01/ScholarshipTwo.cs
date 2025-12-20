using System;

class ScholarshipTwo {

	static void Main(string[] args) {
	
		float fee = float.Parse(Console.ReadLine());
		float discountPercent  = float.Parse(Console.ReadLine());
		float discount = (discountPercent/100) * fee;
		fee = fee - discount;
		
		Console.WriteLine($" The discount amount is INR {discount} and final discounted fee is INR {fee}.");
	
	}

}