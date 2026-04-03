using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class MeanHeight
    {
        public static void Mean() 
        {
            //taking input
            double[] height = new double[11];
            double sum = 0.0;
            Console.WriteLine("Enter the height of each player : ");

            //in the loop where the input is taken, each value is added to sum
            for(int i=0; i<height.Length; i++) 
            {
                height[i] = Convert.ToDouble(Console.ReadLine());
                sum += height[i];
            }

            //output
            Console.WriteLine($"Mean height of the team is : { (sum / 11):F2}");
        }
    }
}
