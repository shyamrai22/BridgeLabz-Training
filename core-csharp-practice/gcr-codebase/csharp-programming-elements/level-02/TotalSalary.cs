using System;

class TotalSalary  {

    static void Main(string[] args) {
	
        Console.Write("Enter the salary : ");
        double salary = double.Parse(Console.ReadLine());
		Console.Write("Enter the bonus : ");
		double bonus = double.Parse(Console.ReadLine());
			
		Console.WriteLine($" The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {salary + bonus}");
		
    }
}
