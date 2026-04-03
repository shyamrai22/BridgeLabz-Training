using System;

namespace BridgeLabzTraining.csharp_strings
{
    public class IndexOutOfRangeArray
    {
        public static void Demo()
        {
            try
            {

                int[] nums = { 10, 20, 30, 40, 50 };
                int val = nums[7];
                Console.WriteLine(val);
            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("Index Out Of Range Exception caught!!!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Caller()
        {
            Demo();
        }
    }
}
