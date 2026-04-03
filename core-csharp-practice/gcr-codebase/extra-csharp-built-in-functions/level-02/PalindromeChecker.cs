using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class PalindromeChecker
    {
        public static void Caller()
        {
            string txt = Input("Enter a string: ");
            bool palindrome = CheckingPalindrome(txt);
            Display(txt, palindrome);
        }

        // Input
        static string Input(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        static bool CheckingPalindrome(string str)
        {
            if (str == null)
                return false;

            int l = 0;
            int r = str.Length - 1;

            while (l < r)
            {
                if (str[l] != str[r])
                    return false;
                l++;
                r--;
            }
            return true;
        }

        // Output
        static void Display(string s, bool res)
        {
            if (res)
                Console.WriteLine($"\"{s}\" : Palindrome");
            else
                Console.WriteLine($"\"{s}\" : Not a Palindrome");
        }
    }
}
