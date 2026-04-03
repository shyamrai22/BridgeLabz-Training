using System;

namespace BridgeLabzTraining.csharp_strings
{
    public class FormatExceptionDemonstration
    {
        public static void Demo()
        {
            try
            {
                string val = "abc";   
                int num = int.Parse(val);  
                Console.WriteLine(num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception caught!!!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Caller()
        {
            Demo();
        }
    }
}
