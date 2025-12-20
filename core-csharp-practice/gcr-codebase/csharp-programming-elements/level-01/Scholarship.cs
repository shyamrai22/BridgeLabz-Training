using System;

class Scholarship {

	static void Main(string[] args) {
	
		float fee = 125000f;
		float discountPercent  = 10f;
		float discount = (discountPercent/100) * 125000;
		fee = fee - discount;
		
		Console.WriteLine($" The discount amount is INR {discount} and final discounted fee is INR {fee}.");
	
	}

}