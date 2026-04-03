using System;

namespace BridgeLabzTraining.strings
{
    internal class CompareStrings
    {
        // Method to compare both strings
        public static bool CompareTwoStrings(string a, string b)
        {
            if(a.Length != b.Length) 
            return false;

            int len = a.Length;

            for (int  i = 0;  i < len;  i++)
            {
                if(a[i] != b[i]) 
                    return false;
            }
            return true;
        }


        // Method to call Compare()
        public static void Caller() 
        {
            Console.Write("Enter a string : ");
            string a = Console.ReadLine();

            Console.Write("Enter a string : ");
            string b = Console.ReadLine();

            bool idxLogic = CompareTwoStrings(a, b);
            bool equalsLogic = a.Equals(b);

            Console.WriteLine($"Result using compare method : {idxLogic}");
            Console.WriteLine($"Result using equals method : {equalsLogic}");
            
        }
    }
}
