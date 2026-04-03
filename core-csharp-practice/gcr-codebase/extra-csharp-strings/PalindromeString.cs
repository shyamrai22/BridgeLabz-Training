using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class PalindromeString
    {
        public static void Caller()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            if (s == null)
                return;

            s = s.ToLower();   

            int l = 0;
            int r = s.Length - 1;
            bool isPalindromeStr = true;

            while (l < r)
            {
                if (s[l] != s[r])
                {
                    isPalindromeStr = false;
                    break;
                }
                l++;
                r--;
            }

            if (isPalindromeStr)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
