using System;

/*
    Summary:
    This class represents the Diwali Mela Lucky Draw logic. The Draw() method accepts
    a number from the user and checks whether it is divisible by both 3 and 5. If the
    condition is satisfied, the user wins a gift and the method returns 1 to indicate
    a successful draw. If the condition is not met, the user is asked to try again and
    the method returns 0, indicating an unsuccessful attempt.
*/


namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.festival_lucky_draw
{
    internal class DiwaliMelaLuckyDraw
    {
        // Method to check if a draw was successfull or not
        public int Draw(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Zero is an invalid number for this game");
                return 0;
            }
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Hurray! You have won a gift!");
                return 1;
            }
                Console.WriteLine("Try Again!");
            return 0;
        }
    }
}
