using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class Handshakes
    {
        // Maximum number of handshakes
        public static int Calculations(int n)
        {
            return (n * (n - 1)) / 2;
        }

        // Calling the method
        public static void Caller()
        {

            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int h = Calculations(n);

            Console.WriteLine($"The maximum number of handshakes among {n} students is {h}");
        }
    }
}
