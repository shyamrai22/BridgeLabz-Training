using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_01
{
    class TimeZones
    {
        public static void Caller()
        {
            DateTimeOffset utc = DateTimeOffset.UtcNow;

            TimeZoneInfo gmt = TimeZoneInfo.Utc;
            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utc, gmt);
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utc, ist);
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utc, pst);

            // Output
            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine($"GMT : {gmtTime}");
            Console.WriteLine($"IST : {istTime}");
            Console.WriteLine($"PST : {pstTime}");
        }
    }
}
