using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.dsa_csharp_practice.stack___queue__hashmap_and_hashing_function.custom_hash_map
{
    class CustomHashMap
    {
        private int cap = 10;
        private LinkedList<HashNode>[] bucket;

        public CustomHashMap()
        {
            bucket = new LinkedList<HashNode>[cap];
            for (int i = 0; i < cap; i++)
            {
                bucket[i] = new LinkedList<HashNode>();
            }
        }

        private int GetIndex(int key)
        {
            return Math.Abs(key.GetHashCode()) % cap;
        }

        public void Put(int key, int val)
        {
            int index = GetIndex(key);

            foreach (HashNode node in bucket[index])
            {
                if (node.Key == key)
                {
                    node.Value = val;
                    Console.WriteLine("Updated key --> " + key);
                    return;
                }
            }

            bucket[index].AddLast(new HashNode(key, val));
            Console.WriteLine("Inserted key --> " + key);
        }

        public int Get(int key)
        {
            int idx = GetIndex(key);

            foreach (HashNode node in bucket[idx])
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
            }
            throw new Exception("Key not found");
        }

        public void Remove(int key)
        {
            int index = GetIndex(key);

            foreach (HashNode node in bucket[index])
            {
                if (node.Key == key)
                {
                    bucket[index].Remove(node);
                    Console.WriteLine("Removed key --> " + key);
                    return;
                }
            }

            Console.WriteLine("Key not found");
        }
    }
}
