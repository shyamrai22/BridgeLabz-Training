namespace AddressBookSystem.ds
{
  public class MyDictionary<K, V>
  {
    private K[] keys;
    private V[] values;
    private int capacity;
    private int count;

    public MyDictionary()
    {
      capacity = 10;
      keys = new K[capacity];
      values = new V[capacity];
      count = 0;
    }

    private int GetIndex(K key)
    {
      int hash = key.GetHashCode();
      return Math.Abs(hash) % capacity;
    }

    public void Add(K key, V value)
    {
      int index = GetIndex(key);

      while (keys[index] != null)
      {
        if (keys[index].Equals(key))
          throw new Exception("Duplicate key");

        index = (index + 1) % capacity;
      }

      keys[index] = key;
      values[index] = value;
      count++;
    }

    public V Get(K key)
    {
      int index = GetIndex(key);

      int startIndex = index;

      while (keys[index] != null)
      {
        if (keys[index].Equals(key))
          return values[index];

        index = (index + 1) % capacity;

        if (index == startIndex)
          break;
      }

      throw new Exception("Key not found");
    }

    public bool ContainsKey(K key)
    {
      int index = GetIndex(key);
      int startIndex = index;

      while (keys[index] != null)
      {
        if (keys[index].Equals(key))
          return true;

        index = (index + 1) % capacity;

        if (index == startIndex)
          break;
      }

      return false;
    }

    public K[] GetAllKeys()
    {
      K[] result = new K[count];
      int index = 0;

      for (int i = 0; i < capacity; i++)
      {
        if (keys[i] != null)
        {
          result[index++] = keys[i];
        }
      }

      return result;
    }

  }
}
