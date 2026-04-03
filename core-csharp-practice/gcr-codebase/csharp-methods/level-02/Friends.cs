using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class Friends
    {
        // Method to find the youngest
        public static int Youngest(int[] age)
        {

            int youngIdx = 0;

            for (int i = 1; i < age.Length; i++)
            {
                if (age[i] < age[youngIdx])
                {
                    youngIdx = i;
                }
            }

            return youngIdx;
        
        }

        // Method to find the tallest
        public static int Tallest(double[] height)
        {

            int tallestIdx = 0;

            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] > height[tallestIdx])
                {
                    tallestIdx = i;
                }
            }

            
            return tallestIdx;
        
        }

        // Calling the methods
        public static void Caller()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] heights = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of {names[i]}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter height of {names[i]}: ");
                heights[i] = Convert.ToDouble(Console.ReadLine());
            }

            int youngestIdx = Youngest(ages);
            int tallestIdx = Tallest(heights);

            Console.WriteLine($"Youngest friend : {names[youngestIdx]}");
            Console.WriteLine($"Tallest friend : {names[tallestIdx]}");
        
        }
    }
}
