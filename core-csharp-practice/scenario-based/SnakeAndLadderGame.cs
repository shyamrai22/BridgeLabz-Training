using System;

/*
<summary>
This console-based Snake & Ladder game is developed using .NET 6+ and core C# fundamentals.
It supports 2 to 4 players who take turns rolling a dice to move across a 100-cell board.
The game applies predefined snakes and ladders to move players down or up accordingly.
Player movements are restricted to exact positions within the board, and the first
player to reach exactly position 100 wins. The program demonstrates proper use of
variables, control flow statements, loops, methods, collections, and random number
generation, following clean coding practices and version control principles.
</summary>
*/

namespace BridgeLabzTraining.Scenario_Based
{
    internal class SnakeAndLadderGame
    {
        // Method to start the Snake and Ladder game
        public static void Implementation()
        {
            Console.WriteLine("Enter the number of players between 2 and 4:");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            if (numberOfPlayers < 2 || numberOfPlayers > 4)
            {
                Console.WriteLine("Number of players is invalid!");
                return;
            }

            int[] playerArray = new int[numberOfPlayers];
            bool didWin = false;

            while (!didWin)
            {
                for (int i = 0; i < playerArray.Length; i++)
                {
                    int diceNumber = RollDice();
                    Console.WriteLine($"Player {i + 1} rolled: {diceNumber}");

                    int oldPosition = playerArray[i];
                    int newPosition = MovePlayer(oldPosition, diceNumber);

                    if (oldPosition == newPosition)
                    {
                        Console.WriteLine("Cannot move! Next position exceeds 100.");
                        continue;
                    }

                    int resultingPosition = ApplySnakeAndLadder(newPosition);
                    Console.WriteLine(
                        $"Player {i + 1} moved from {oldPosition} to {resultingPosition}"
                    );

                    playerArray[i] = resultingPosition;

                    if (CanWin(playerArray[i]))
                    {
                        Console.WriteLine($"🎉 Player {i + 1} WINS!");
                        didWin = true;
                        break;
                    }
                }
            }
        }

        // Method to roll the dice
        public static int RollDice()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        // Method to move the player
        public static int MovePlayer(int oldPosition, int diceValue)
        {
            return (oldPosition + diceValue > 100)? oldPosition: oldPosition + diceValue;
        }

        // Method to apply snake or ladder
        public static int ApplySnakeAndLadder(int newPosition)
        {
            int[] snakes = { 99, 89, 63, 24 };
            int[] snakesDown = { 5, 43, 27, 9 };

            int[] ladders = { 7, 22, 48, 73 };
            int[] laddersUp = { 38, 52, 78, 94 };

            for (int i = 0; i < snakes.Length; i++)
            {
                if (newPosition == snakes[i])
                {
                    Console.WriteLine($"🐍 Snake bite! Move down to {snakesDown[i]}");
                    return snakesDown[i];
                }
            }

            for (int i = 0; i < ladders.Length; i++)
            {
                if (newPosition == ladders[i])
                {
                    Console.WriteLine($"🪜 Ladder climb! Move up to {laddersUp[i]}");
                    return laddersUp[i];
                }
            }

            return newPosition;
        }

        // Method to check win condition
        public static bool CanWin(int position)
        {
            return position == 100;
        }

        // Method to call the above methods
        public static void Caller()
        {
            Implementation();
            Console.WriteLine("Game Over!");
        }
    }
}
