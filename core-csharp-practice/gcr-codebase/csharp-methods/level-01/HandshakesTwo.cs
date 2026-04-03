using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class HandshakesTwo
    {
        // Maximum number of handshakes
        public static int CalculateHandshakes(int numberOfStudents)
        {
            return (numberOfStudents * (numberOfStudents - 1)) / 2;
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            int h = CalculateHandshakes(numberOfStudents);
            Console.WriteLine(h);
        }
    }
}
