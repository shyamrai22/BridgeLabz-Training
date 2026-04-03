using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class VoterEligibility
    {
        public static void CheckEligibility()
        {
            //taking input
            Console.WriteLine("Enter the age of the students:");
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }
            //applying logic to check age of students
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] >= 18)
                {
                    Console.WriteLine($"Student with age {ages[i]} is eligible to vote");
                }
                else if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age entered");
                }
                else
                {
                    Console.WriteLine($"Student with age {ages[i]} is not eligible to vote");
                }
            }
        }
    }

}
