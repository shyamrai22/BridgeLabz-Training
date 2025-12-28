using System;

namespace BridgeLabzTraining.csharp_strings
{
    internal class NullReference
    {
        public static void Demo() 
        {
            try
            {
                string s = null;
                int len = s.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Reference Exception caught!!!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Caller()
        {
            Demo();
        }
    }
}
