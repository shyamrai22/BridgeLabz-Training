using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class Anagram
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter 1st string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter 2nd string: ");
            string str2 = Console.ReadLine();

            if (str1 == null || str2 == null)
                return;

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not anagrams");
                return;
            }

            bool[] visits = new bool[str2.Length];

            for (int i = 0; i < str1.Length; i++)
            {
                bool fnd = false;

                for (int j = 0; j < str2.Length; j++)
                {
                    if (!visits[j] && str1[i] == str2[j])
                    {
                        visits[j] = true;
                        fnd = true;
                        break;
                    }
                }

                if (!fnd)
                {
                    Console.WriteLine("Not anagrams");
                    return;
                }
            }
            // Output
            Console.WriteLine("Anagrams");
        }
    }
}
