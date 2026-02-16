namespace AddressBookSystem.ds
{
  public class MyList<T>
  {
    private T[] items;
    private int count;

    public MyList()
    {
      items = new T[5];
      count = 0;
    }

    public void Add(T item)
    {
      if (count == items.Length)
      {
        Resize();
      }

      items[count++] = item;
    }

    private void Resize()
    {
      T[] newArray = new T[items.Length * 2];
      for (int i = 0; i < items.Length; i++)
      {
        newArray[i] = items[i];
      }
      items = newArray;
    }

    public T Get(int index)
    {
      if (index < 0 || index >= count)
        throw new IndexOutOfRangeException();

      return items[index];
    }

    public int Count()
    {
      return count;
    }

    public void RemoveAt(int index)
    {
      if (index < 0 || index >= count)
        throw new IndexOutOfRangeException();

      for (int i = index; i < count - 1; i++)
      {
        items[i] = items[i + 1];
      }

      items[count - 1] = default(T);
      count--;
    }

    public int FindIndex(Func<T, bool> predicate)
    {
      for (int i = 0; i < count; i++)
      {
        if (predicate(items[i]))
          return i;
      }
      return -1;
    }

    public bool Contains(T item)
    {
      for (int i = 0; i < count; i++)
      {
        if (items[i].Equals(item))
          return true;
      }
      return false;
    }

    public MyList<T> Clone()
    {
      MyList<T> newList = new MyList<T>();

      for (int i = 0; i < count; i++)
      {
        newList.Add(items[i]);
      }

      return newList;
    }

    public void Set(int index, T value)
    {
      if (index < 0 || index >= count)
        throw new IndexOutOfRangeException();

      items[index] = value;
    }



  }
}
