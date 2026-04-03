using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class MostFrequentChar
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            if (str == null || str.Length == 0)
                return;

            char maxCharacter = str[0];
            int maxCnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int cnt = 1;

                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        cnt++;
                }

                if (cnt > maxCnt)
                {
                    maxCnt = cnt;
                    maxCharacter = str[i];
                }
            }
            // Output
            Console.WriteLine($"Most frequent character: '{maxCharacter}'");
        }
    }
}
