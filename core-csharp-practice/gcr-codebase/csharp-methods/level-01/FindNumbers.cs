using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class FindNumbers
    {
        // Finding smallest and largest number among three numbers
        public static int[] SmallestAndLargest(int n1, int n2, int n3)
        {
            int s = n1;
            int l = n1;

            if (n2 < s)
                s = n2;

            if (n3 < s)
                s = n3;

            if (n2 > l)
                l = n2;

            if (n3 > l)
                l = n3;

            return new int[] { s, l };
        }

        // Calling the method
        public static void Caller()
        {
            Console.Write("Enter number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] res = SmallestAndLargest(num1, num2, num3);

            Console.WriteLine($"Smallest number : {res[0]}");
            Console.WriteLine($"Largest number : {res[1]}");
        }
    }
}
