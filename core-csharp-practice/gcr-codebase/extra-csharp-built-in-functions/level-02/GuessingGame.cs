using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class NumberGuessingGame
    {
        public static void Caller()
        {
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Respond with:");
            Console.WriteLine("h - if guess is too high");
            Console.WriteLine("l - if guess is too low");
            Console.WriteLine("c - if guess is correct");
            Console.WriteLine();

            int l = 1;
            int h = 100;
            bool correct = false;

            while (!correct)
            {
                int guess = Guess(l, h);
                Console.Write($"Is your number {guess}? (h/l/c): ");

                char fb = Feedback();

                correct = ProcessFb(fb, guess, ref l, ref h);
            }
        }


        static int Guess(int l, int h)
        {
            return (l + h) / 2;
        }


        static char Feedback()
        {
            return Console.ReadLine().ToLower()[0];
        }


        static bool ProcessFb(char fb, int guess, ref int l, ref int h)
        {
            if (fb == 'c')
            {
                Console.WriteLine("Guessed your number correctly!");
                return true;
            }

            else if (fb == 'h')
                h = guess - 1;

            else if (fb == 'l')
                l = guess + 1;

            else
                Console.WriteLine("Please enter h, l, or c.");

            return false;
        }
    }
}
