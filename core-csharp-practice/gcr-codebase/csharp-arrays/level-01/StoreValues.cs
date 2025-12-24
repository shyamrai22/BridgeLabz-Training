using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class StoreValues
    {
        public static void Store() 
        {
            //taking input and declaring few key variable
            int[] nums = new int[10];
            int sum = 0;
            int final = 0;
            Console.WriteLine("Enter the elemets of the array : ");
            //in the loop num is added unless it is less than one
            //if num is less than one, loop is stoppes and output is displayed 
            for (int i = 0; i < 10; i++) 
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    sum += num;
                    nums[i] = num;
                    final = i;
                }
                else 
                {
                    break;
                }
            }
            //output 
            Console.WriteLine($"Sum of elements : {sum}");
            for (int i = 0; i <= final; i++) 
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
