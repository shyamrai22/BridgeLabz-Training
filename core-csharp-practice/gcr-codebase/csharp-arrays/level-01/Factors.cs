using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class Factors
    {
        public static void GetFactors() 
        {
            //input
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] fac = new int[(num/2) + 1];
            int idx = 0;

            //factors stored in array fac
            for (int i = 1; i <= num; i++) 
            {
                if (num % i == 0) 
                {
                    fac[idx++] = i;
                }
            }

            //output
            for (int i = 0; i < idx; i++)
            {
                Console.WriteLine(fac[i]);
            }
        }
    }
}
