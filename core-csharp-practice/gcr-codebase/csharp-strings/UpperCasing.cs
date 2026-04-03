using System;

namespace BridgeLabzTraining.csharp_strings
{
    public class UpperCasing
    {
        public static string UpperCaseUsingAscii(string str)
        {
            char[] chr = str.ToCharArray();

            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] >= 'a' && chr[i] <= 'z')
                {
                    chr[i] = (char)(chr[i] - 32);
                }
            }

            return new string(chr);
        }

        public static void Caller()
        {
            string txt = "BridgeLabz Training";

            string ascii = UpperCaseUsingAscii(txt);
            string builtIn = txt.ToUpper();

            Console.WriteLine("Result using ascii : " + ascii);
            Console.WriteLine("Result using ToUpper() : " + builtIn);
        }
    }
}
