using System;

namespace BridgeLabzTraining.extras_csharp_strings
{
    class CompareStrings
    {
        public static void Caller()
        {
            //Input
            Console.Write("Enter 1st string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter 2nd string: ");
            string str2 = Console.ReadLine();

            if (str1 == null || str2 == null)
                return;

            int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;
            bool isDiff = false;

            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] < str2[i])
                {
                    Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");
                    isDiff = true;
                    break;
                }
                else if (str1[i] > str2[i])
                {
                    Console.WriteLine($"\"{str2}\" comes before \"{str1}\" in lexicographical order");
                    isDiff = true;
                    break;
                }
            }

            //Output
            if (!isDiff)
            {
                if (str1.Length < str2.Length)
                    Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order");

                else if (str1.Length > str2.Length)
                    Console.WriteLine($"\"{str2}\" comes before \"{str1}\" in lexicographical order");

                else
                    Console.WriteLine("Both strings are equal");
            }
        }
    }
}
