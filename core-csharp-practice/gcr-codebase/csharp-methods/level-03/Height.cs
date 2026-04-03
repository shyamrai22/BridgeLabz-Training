using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Height
    {
        // Generating random heights
        public static int[] Generating(int s)
        {
            int[] height = new int[s];
            Random rnd = new Random();

            for (int i = 0; i < s; i++)
            {
                height[i] = rnd.Next(150, 251);
            }

            return height;
        }

        // Sum of heights
        public static int Sum(int[] height)
        {
            int sum = 0;

            for (int i = 0; i < height.Length; i++)
            {
                sum += height[i];
            }

            return sum;

        }

        // Mean of height
        public static double Mean(int[] height)
        {
            int sum = Sum(height);
            return (double)sum / height.Length;
        }

        // Shortest height
        public static int Shortest(int[] height)
        {
            int min = height[0];

            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] < min)
                    min = height[i];
            }

            return min;

        }

        // Tallest height
        public static int FindTallest(int[] height)
        {
            int max = height[0];

            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] > max)
                    max = height[i];
            }

            return max;

        }

        // Calling above methods
        public static void Caller()
        {
            int[] height = Generating(11);

            Console.WriteLine("Heights of players:");

            for (int i = 0; i < height.Length; i++)
            {
                Console.WriteLine($"Player {i + 1}: {height[i]}");
            }

            int s = Shortest(height);
            int t = FindTallest(height);
            double m = Mean(height);

            Console.WriteLine();
            Console.WriteLine($"Shortest Height : {s} cm");
            Console.WriteLine($"Tallest Height : {t} cm");
            Console.WriteLine($"Mean Height : {Math.Round(m, 2)} cm");

        }
    }
}
