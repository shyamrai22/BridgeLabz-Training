using System;

namespace BridgeLabzTraining.csharp_strings
{
    internal class Characters
    {
        // Method to return all characters of a string
        public static char[] ReturnCharacters(string s) 
        {
            char[] chars = new char[s.Length];

            for(int i=0; i<s.Length; i++)
                chars[i] = s[i];

            return chars;
        }

        // Caller method
        public static void Caller() 
        {
            Console.Write("Enter a string : ");
            string s = Console.ReadLine();
            
            int n = s.Length;

            char[] usingReturnCharacters = ReturnCharacters(s);
            char[] usingToCharArray = s.ToCharArray();

            Console.WriteLine($"String : {s}");
            Console.Write("Using ReturnCharacters() : ");
            foreach(char ch in usingReturnCharacters) 
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();

            Console.Write("Using ToCharArray() : ");
            foreach (char ch in usingToCharArray)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
