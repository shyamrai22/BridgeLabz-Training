using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class OddEven
    {
        public static void Seperate() 
        {
            //input
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] odd = new int[(num / 2) + 1];
            int[] even = new int[(num / 2) + 1];
            int oi = 0;
            int ei = 0;

            //seperating odd and even numbers
            for(int i=1; i<=num; i++) 
            {
                if(i%2 != 0) 
                {
                    odd[oi++] = i;
                }
                else
                {
                    even[ei++] = i;
                }
            }

            //displaying the output
            for (int i = 0; i < oi; i++)
            {
                Console.WriteLine(odd[i]);
            }
            Console.WriteLine("-----------------");
            for (int i = 0; i < ei; i++)
            {
                Console.WriteLine(even[i]);
            }
        }
    }
}
