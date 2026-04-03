using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class OperationsOnNumbers
    {
        // Generating array of 4-digit random numbers
        public static int[] GeneratingNumber(int s)
        {

            int[] nums = new int[s];
            Random rnd = new Random();

            for (int i = 0; i < s; i++)
            {
                
                nums[i] = rnd.Next(1000, 10000);
            }

            return nums;
        
        }

        // Finding average, minimum and maximum
        public static double[] AvgMinMax(int[] nums)
        {
        
            int min = nums[0];
            int max = nums[0];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                min = Math.Min(min, nums[i]);
                max = Math.Max(max, nums[i]);
            }

            double avg = (double)sum / nums.Length;

            return new double[] { avg, min, max };
        
        }

        // Calling above methods
        public static void Caller()
        {
        
            int[] nums = GeneratingNumber(5);

            Console.WriteLine("Generated 4-digit random numbers:");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            double[] res = AvgMinMax(nums);

            Console.WriteLine($"Avg : {Math.Round(res[0], 2)}");
            Console.WriteLine($"Min : {res[1]}");
            Console.WriteLine($"Max : {res[2]}");
        
        }
    }
}
