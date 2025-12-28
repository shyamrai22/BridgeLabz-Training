using System;

namespace BridgeLabzTraining.csharp_strings
{
public class IndexOutOfRange    {
        public static void Demo()
        {
            try
            {
                int[] nums = new int[5];
                nums[8] = 1;
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
