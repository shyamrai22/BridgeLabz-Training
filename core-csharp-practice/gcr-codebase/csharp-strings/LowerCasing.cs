using System;

namespace BridgeLabzTraining.csharp_strings
{
    public class LowerCasing
    {
        public static string LowerCaseUsingAscii(string str)
        {
            char[] chr = str.ToCharArray();

            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] >= 'A' && chr[i] <= 'Z')
                    chr[i] = (char)(chr[i] + 32);
            }
            return new string(chr);
        }

        public static void Caller()
        {
            string txt = "BridgeLabz Training";
            string ascii = LowerCaseUsingAscii(txt);
            string builtIn = txt.ToLower();

            Console.WriteLine("Result using ASCII logic : " + ascii);
            Console.WriteLine("Result using ToLower()   : " + builtIn);
        }
    }
}
