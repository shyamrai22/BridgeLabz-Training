using System;

class Animal{}

class Tiger : Animal {}

class Car{}

class Operators{
			
	static void Main(){
		
		// 1 Arithematic Operators
		
		int x = 12;
		int y = 10;
		
		// 1.1 Addition
		Console.WriteLine(x + y);
		
		// 1.2 Subtraction
		Console.WriteLine(x - y);
		
		// 1.3 Multiplication
		Console.WriteLine(x * y);
		
		// 1.4 Division
		Console.WriteLine(x / y);
		
		// 1.5 Modulus
		Console.WriteLine(x % y);
		
				
		
		// 2 Realtional Operators
		
		// 2.1 Equal to
		Console.WriteLine(x == y);
		
		// 2.2 Not equal to 
		Console.WriteLine(x != y);
		
		// 2.3 Greater than 
		Console.WriteLine(x > y);
		
		// 2.4 Less than
		Console.WriteLine(x < y);
		
		// 2.5 Greater than or equal to 
		Console.WriteLine(x >= y);
		
		// 2.6 Less than or equal to 
		Console.WriteLine(x <= y);
				
				
		
		// 3 Logical Operators
		
		// Logical AND
		Console.WriteLine(x<y && y>x);
		
		// Logical OR
		Console.WriteLine(x<y || y>x);
		
		// Logical NOT
		Console.WriteLine(!(x == y));
		
				
		
		// 4 Assignment Operators
		
		// 4.1 Assignment
		int a = 4;
		
		// 4.2 Addtion Assignment
		x += 4;
		
		// 4.3 Subtraction Assignment
		y -= 3;
		
		// 4.4 Multiplication Assignment
		x *= 2;
		
		// 4.5 Division Assignment
		y /= 10;
		
		// 4.6 Modulus Assignment
		x %= 2;
		
				
		
		// 5 Unary Operators
		
		// 5.1 Unary plus
		int z = +x;
		
		// 5.2 Unary minus
		int f = -x;
		
		// 5.3 Increment 
		a++;
		
		// 5.4 Decrement
		a--;
		
		// 5.5 Logical Complement
		Console.WriteLine(!true);
		
						
		
		// 8 is Operator
		
		Animal obj1 = new Tiger();
		Car obj2 = new Car();
		
		Console.WriteLine(obj1 is Animal);
		Console.WriteLine(obj1 is Car);
		
	}
	
}