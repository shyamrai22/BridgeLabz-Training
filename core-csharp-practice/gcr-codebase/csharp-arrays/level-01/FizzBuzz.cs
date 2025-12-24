using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_01
{
    internal class FizzBuzz
    {
        public static void Fizzy()
        {
            Console.Write("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            //input
            string[] res = new string[num + 1];

            //loop
            for (int i = 0; i <= num; i++)
            {
                if (i == 0)
                {
                    res[i] = "0";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    res[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    res[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    res[i] = "Buzz";
                }
                else
                {
                    res[i] = i.ToString();
                }
            }

            //output
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Position {i} = {res[i]}");
            }
        }
    }
}
