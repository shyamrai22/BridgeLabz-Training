using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class ReplaceWords
    {
        public static void Caller()
        {
            // Input
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();

            if (str == null)
                return;

            Console.Write("Enter word to replace: ");
            string oWord = Console.ReadLine();

            if (oWord == null || oWord.Length == 0)
                return;

            Console.Write("Enter new word: ");
            string nWord = Console.ReadLine();

            if (nWord == null)
                return;

            char[] res = new char[str.Length * 2];
            int idx = 0;

            for (int i = 0; i < str.Length;)
            {
                bool match = true;

                if (i + oWord.Length <= str.Length)
                {
                    for (int j = 0; j < oWord.Length; j++)
                    {
                        if (str[i + j] != oWord[j])
                        {
                            match = false;
                            break;
                        }
                    }
                }
                else
                    match = false;

                if (match)
                {
                    for (int k = 0; k < nWord.Length; k++)
                    {
                        res[idx++] = nWord[k];
                    }
                    i += oWord.Length;
                }
                else
                {
                    res[idx++] = str[i];
                    i++;
                }
            }
            // Output
            string fSentence = new string(res, 0, idx);
            Console.WriteLine("Modified : " + fSentence);
        }
    }
}
