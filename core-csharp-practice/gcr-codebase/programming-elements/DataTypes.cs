using System;

class DataTypes {
	
	static void Main(string[] args) {
		
		// int DataType
		int num1 = 10;
		Console.WriteLine("Integer : " + num1);
		
		// float DataType
		float num2 = 66.97f;
		Console.WriteLine("Float : " + num2);
		
		// double DataType
		double num3 = 123.666666d;
		Console.WriteLine("Double : " + num3);
		
		// long DataType
		long num4 = 1500000000L;
		Console.WriteLine("Long : " + num4);
		
		// bool DataType
		bool flag = true;
		Console.WriteLine("Bool : " + flag);
		
		// char DataType
		char ch1 = 'A';
		Console.WriteLine("Char : " + ch1);

		// implicit conversion
		char ch2 = 'A';
		int num11 = ch2;
		long num12 = num11;
		float num13 = num12;
		double num14 = num13;
			
		Console.WriteLine(ch2);
		Console.WriteLine(num11);
		Console.WriteLine(num12);
		Console.WriteLine(num13);
		Console.WriteLine(num14);
			
		// explicit conversion
		char ch3 = Convert.ToChar(65);
		int num21 = Convert.ToInt32(222134532L);
		float num22 = (float) 321.0938D;
		
		Console.WriteLine(ch3);
		Console.WriteLine(num21);
		Console.WriteLine(num22);
							
	}
}