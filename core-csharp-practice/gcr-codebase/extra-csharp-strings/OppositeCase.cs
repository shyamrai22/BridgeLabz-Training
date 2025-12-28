using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class OppositeCase
    {
        public static void Caller()
        {
            //Input
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            if (str == null)
                return;

            char[] res = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch >= 'a' && ch <= 'z')
                    res[i] = (char)(ch - 32);
                
                else if (ch >= 'A' && ch <= 'Z')
                    res[i] = (char)(ch + 32);
                
                else
                    res[i] = ch;
            }
            //Output
            string toggleStr = new string(res);
            Console.WriteLine($"Toggled case string: {toggleStr}");
        }
    }
}
