using System;

/*
    Summary:
    This program implements a Diwali Mela Lucky Draw game using C#. The Caller class
    provides a menu-driven interface that allows the user to start the lucky draw
    or exit the program. When the user chooses to play, a number is entered and passed
    to the Draw() method of the DiwaliMelaLuckyDraw class. The draw logic checks whether
    the number is divisible by both 3 and 5. If the condition is satisfied, the user
    wins a gift and the program exits; otherwise, the user is asked to try again.
    The program continues running until the user wins or chooses to exit.
*/


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.festival_lucky_draw
{
    internal class Caller
    {
        public static void Main(string[] args)
        {
            DiwaliMelaLuckyDraw obj = new DiwaliMelaLuckyDraw();
            bool exit = false;
            Console.WriteLine("Welcome to lucky draw, try your luck and win something exciting");

            Console.WriteLine("To exit the draw press 0 ");
            Console.WriteLine("To start the game press 1 ");
            Console.Write("Enter your choice --> ");

            while (!exit)
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the code...");
                        exit = true;
                        break;

                    case 1:
                        while (true)
                        {
                            Console.Write("Enter a number --> ");
                            int result = obj.Draw(int.Parse(Console.ReadLine()));

                            if (result == 1)
                            {
                                exit = true;
                                break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Enter a valid option (0 or 1)");
                        continue;
                }
            }
        }
    }
}
