using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class MultiplicationTable
    {
        public static void Table() 
        {
            //taking input
            int[] table = new int[10];
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            //storing table in array
            for (int i = 0; i < table.Length; i++) 
            {
                table[i] = num * i; 
            }

            //displaying result
            for (int i = 0; i < table.Length; i++) 
            {
                Console.WriteLine($"{num} x {i} = {table[i]}"); 
            }
        }
    }
}
