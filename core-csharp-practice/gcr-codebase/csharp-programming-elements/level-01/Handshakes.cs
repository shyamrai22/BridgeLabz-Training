using System;

class Handshakes{

    static void Main(string[] args) {
	
        Console.Write("Enter the number of students : ");
        int numberOfStudents  = int.Parse(Console.ReadLine());
		
		int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;		
		
        Console.WriteLine($"The number of possible handshakes : {maxHandshakes}");
		
    }
}
