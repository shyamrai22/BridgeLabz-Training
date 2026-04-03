using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class Numbers
    {
        // Checking whether number is positive
        public static bool Positive(int num)
        {
            return num >= 0;
        }

        // Checking whether number is even
        public static bool Even(int num)
        {
            return num % 2 == 0;
        }

        
        public static int Comparison(int num1, int num2)
        {
            if (num1 > num2)
                return 1;

            else if (num1 < num2)
                return -1;
            
            else
                return 0;
        
        }

        // Calling above methods
        public static void Caller()
        {
            int[] nums = new int[5];

            
            for (int i = 0; i < nums.Length; i++)
            {

                Console.Write($"Enter number {i + 1}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            
            }

            Console.WriteLine();

            
            for (int i = 0; i < nums.Length; i++)
            {
                if (Positive(nums[i]))
                {
                    if (Even(nums[i]))
                        Console.WriteLine($"{nums[i]} : Positive and Even");

                    else
                        Console.WriteLine($"{nums[i]} : Positive and Odd");
                }

                else
                {
                    Console.WriteLine($"{nums[i]} : Negative");
                }

            }

            Console.WriteLine();

            
            int res = Comparison(nums[0], nums[nums.Length - 1]);

            if (res == 1)
                Console.WriteLine("First element is greater");

            else if (res == -1)
                Console.WriteLine("Last element is greater");
            
            else
                Console.WriteLine("Equal");
        
        }
    }
}
