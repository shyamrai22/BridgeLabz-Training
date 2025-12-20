using System;

class TotalPrice{

    static void Main(string[] args) {
	
        Console.Write("Enter the unit price : ");
        double unitPrice = double.Parse(Console.ReadLine());
		
		Console.Write("Enter the quantity : ");
        double quantity = double.Parse(Console.ReadLine());		
		
        Console.WriteLine($"The total purchase price is INR {unitPrice * quantity} if the quantity {quantity} and unit price is INR {unitPrice}");
		
    }
}
