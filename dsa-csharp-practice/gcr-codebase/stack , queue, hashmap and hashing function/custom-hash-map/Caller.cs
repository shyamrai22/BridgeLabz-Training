using System;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.custom_hash_map
{
    class Caller
    {
        public static void Main(string[] args)
        {
            CustomHashMap map = new CustomHashMap();

            map.Put(1, 100);
            map.Put(2, 200);
            map.Put(11, 300);
            Console.WriteLine("Value for 1 --> " + map.Get(1));
            Console.WriteLine("Value for 2 --> " + map.Get(2));
            Console.WriteLine("Value for 11 --> " + map.Get(11));
            map.Remove(2);
            //map.Get(2);
        }
    }
}
