using System;

namespace BridgeLabzTraining.csharp_strings
{
    internal class Substring
    {
        // Methods to create a substring
        public static string CreateSubstring(string s, int start, int end) 
        {
            string subStr = "";

            for (int i=start; i<=end; i++) 
                subStr += s[i];
            
            return subStr;
        }

        // Method to take input
        public static void Caller() 
        {
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();

            Console.Write("Enter start index : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end index : ");
            int end = int.Parse(Console.ReadLine());

            if (start < 0 || end > s.Length) 
            {
                Console.WriteLine("Enter valid index");
                return;
            }

            string usingAboveMethods = CreateSubstring(s, start, end);
            string usingBuilltIn = s.Substring(start, end);

            Console.WriteLine($"Using own method : {usingAboveMethods}");
            Console.WriteLine($"Using built-in method : {usingBuilltIn}");

        }
    }
}
