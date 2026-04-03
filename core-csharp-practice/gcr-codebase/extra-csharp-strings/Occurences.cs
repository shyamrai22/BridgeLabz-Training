using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class Occurrences
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            if (str == null)
                return;

            Console.Write("Enter substring: ");
            string subStr = Console.ReadLine();

            if (subStr == null || subStr.Length == 0)
                return;

            int cnt = 0;

            for (int i = 0; i <= str.Length - subStr.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < subStr.Length; j++)
                {
                    if (str[i + j] != subStr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                    cnt++;
            }
            //Output
            Console.WriteLine("Occurrences: " + cnt);
        }
    }
}
