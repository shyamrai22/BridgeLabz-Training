using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class LongestWord
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();

            if (str == null)
                return;

            int maxLength = 0;
            int currLength = 0;
            int endIdx = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    currLength++;
                
                else
                {
                    if (currLength > maxLength)
                    {
                        maxLength = currLength;
                        endIdx = i - 1;
                    }
                    currLength = 0;
                }
            }

            if (currLength > maxLength)
            {
                maxLength = currLength;
                endIdx = str.Length - 1;
            }
            // Output
            string longest = str.Substring(endIdx - maxLength + 1, maxLength);
            Console.WriteLine($"Longest word: {longest}");
        }
    }
}
