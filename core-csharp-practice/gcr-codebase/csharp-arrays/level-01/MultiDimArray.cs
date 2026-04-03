using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class MultiDimArray
    {
        public static void ConvertArray()
        {
            //Input
            Console.Write("Enter rows:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter columns:");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[r, c];

            Console.WriteLine("Enter elements of the matrix:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] arr = new int[r * c];
            int arrIndex = 0;

            // Copying the 2d array into 1d array

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    arr[arrIndex] = matrix[i, j];
                    arrIndex++;
                }
            }

            // Displaying the resultant 1d array

            Console.WriteLine("1D Array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}