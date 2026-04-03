using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class ReverseString
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            if (str == null)
                return;

            char[] res = new char[str.Length];
            int idx = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                res[idx] = str[i];
                idx++;
            }

            // Output
            Console.WriteLine($"Reversed String: {new string(res)}");
        }
    }
}
