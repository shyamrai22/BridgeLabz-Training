using System;

namespace BridgeLabzTraining.csharp_strings
{
    public class TextToWords
    {
        public static int GetLength(string str)
        {
            int cnt = 0;
            
            foreach (char ch in str)
                cnt++;

            return cnt;
        }

        public static string[,] SplitCalculate(string txt)
        {
            int word = 0;
            bool inWord = false;

            foreach (char ch in txt)
            {
                if (ch != ' ' && !inWord)
                {
                    word++;
                    inWord = true;
                }
                else if (ch == ' ')
                    inWord = false;
            }

            string[,] res = new string[word, 2];

            int idx = 0;
            string currWord = "";

            foreach (char ch in txt)
            {
                if (ch != ' ')
                {
                    currWord += ch;
                }
                else if (currWord != "")
                {
                    res[idx, 0] = currWord;
                    res[idx, 1] = GetLength(currWord).ToString();
                    idx++;
                    currWord = "";
                }
            }

            if (currWord != "")
            {
                res[idx, 0] = currWord;
                res[idx, 1] = GetLength(currWord).ToString();
            }

            return res;
        }

        public static void Caller()
        {
            string txt = "BridgeLabz Training Program";

            string[,] words = SplitCalculate(txt);

            for (int i = 0; i < words.GetLength(0); i++)
                Console.WriteLine(words[i, 0] + ": " + words[i, 1]);
        }
    }
}
