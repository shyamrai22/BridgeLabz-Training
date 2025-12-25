using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Otp
    {

        // Generating a 6-digit OTP 
        public static int Generation()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 1000000); 
        }


        // Generating OTPs and store in array
        public static int[] OtpArray(int size)
        {
            int[] otps = new int[size];

            for (int i = 0; i < size; i++)
            {
                otps[i] = Generation();
            }

            return otps;
        }

        
        public static bool OtpsUnique(int[] otp)
        {
            for (int i = 0; i < otp.Length; i++)
            {
                for (int j = i + 1; j < otp.Length; j++)
                {
                    if (otp[i] == otp[j])
                        return false;
                }
            }

            return true;
        }

        // Calling above methods
        public static void Caller()
        {

            int[] otps = OtpArray(10);

            Console.WriteLine("Generated OTPs:");
            for (int i = 0; i < otps.Length; i++)
            {
                Console.WriteLine(otps[i]);
            }

            bool unique = OtpsUnique(otps);
            Console.WriteLine($"All otps are unique: {unique}");

        }
    }
}
