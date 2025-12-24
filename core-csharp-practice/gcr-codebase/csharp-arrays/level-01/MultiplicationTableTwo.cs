using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class MultiplicationTableTwo
    {
        public static void TableTwo()
        {
            //taking input
            int[] table = new int[4];
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            //storing table in array
            for (int i = 6; i < 10; i++)
            {
                table[i-6] = num * i;
            }

            //displaying result
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"{num} x {i+6} = {table[i]}");
            }
        }
    }
}
