using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class RemoveCharacter
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            if (s == null)
                return;

            Console.Write("Enter character: ");
            string charInput = Console.ReadLine();

            if (charInput == null || charInput.Length == 0)
                return;

            char removeCharacter = charInput[0];
            char[] res = new char[s.Length];
            int idx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != removeCharacter)
                {
                    res[idx] = s[i];
                    idx++;
                }
            }
            // Output
            string finalString = new string(res, 0, idx);
            Console.WriteLine("Modified String: " + finalString);
        }
    }
}
