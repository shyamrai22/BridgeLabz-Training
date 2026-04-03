using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class Duplicate
    {
        public static void Caller()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            if (s == null)
                return;

            char[] res = new char[s.Length];
            int idx = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < idx; j++)
                {
                    if (s[i] == res[j])
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    res[idx] = s[i];
                    idx++;
                }
            }

            string finalStr = new string(res, 0, idx);
            Console.WriteLine("Duplicates removed: " + finalStr);
        }
    }
}
