using System;

namespace BridgeLabzTraining.csharp_strings
{
    public class ArgumentOutOfRange
    {
        public static void Demo()
        {
            try
            {
                string txt = "Hello World";
                string res = txt.Substring(15, 3);
                Console.WriteLine(res);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Argument Out Of Range Exception caught!!!");
                Console.WriteLine(ex.Message);
            }
        }
        //Method to call Demo()
        public static void Caller()
        {
            Demo();
        }
    }
}
