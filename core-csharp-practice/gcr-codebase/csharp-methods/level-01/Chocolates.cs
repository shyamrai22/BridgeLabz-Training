using System;

namespace BridgeLabzTraining.methods.level_01
{
    internal class Chocolates
    {
        public static int[] Distribution(int numOfChocolates, int numOfChildren)
        {
            int each = numOfChocolates / numOfChildren;
            int remains = numOfChocolates % numOfChildren;

            return new int[] { each, remains };
        }

        // Calling the method
        public static void Caller()
        {

            Console.Write("Enter number of chocolates: ");
            int numOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of children: ");
            int numOfChildren = Convert.ToInt32(Console.ReadLine());

            int[] res = Distribution(numOfChocolates, numOfChildren);

            Console.WriteLine($"Each child gets : {res[0]}");
            Console.WriteLine($"Remaining chocolates : {res[1]}");
        
        }
    }
}
