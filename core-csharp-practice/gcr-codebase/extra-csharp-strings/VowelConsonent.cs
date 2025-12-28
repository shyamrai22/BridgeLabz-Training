using System;

namespace BridgeLabzTraining.extras_csharp_strings
{ }

class VowelConsonant
{
    public static void Caller()
    {
        // Input
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int v = 0, c = 0;

        foreach (char chr in str.ToLower())
        {
            if (chr >= 'a' && chr <= 'z')
            {
                if (chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u')
                    v++;

                else
                    c++;
            }
        }
        // Output

        Console.WriteLine($"Vowels: {v}");
        Console.WriteLine($"Consonants: {c}");
    }
}
