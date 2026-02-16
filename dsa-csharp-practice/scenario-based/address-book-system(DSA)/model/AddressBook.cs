using AddressBookSystem.ds;

namespace AddressBookSystem.model
{


  public class AddressBook
  {
    private MyDictionary<string, MyList<Contact>> cityIndex;
    private MyDictionary<string, MyList<Contact>> stateIndex;
    private MyList<Contact> contacts;

    public AddressBook()
    {
      contacts = new MyList<Contact>();
      cityIndex = new MyDictionary<string, MyList<Contact>>();
      stateIndex = new MyDictionary<string, MyList<Contact>>();
    }


    public bool AddContact(Contact contact)
    {
      if (contacts.Contains(contact))
        return false;

      contacts.Add(contact);

      AddToCityIndex(contact);
      AddToStateIndex(contact);

      return true;
    }


    public MyList<Contact> GetContacts()
    {
      return contacts;
    }

    public bool EditContact(string firstName, string lastName, Contact updatedContact)
    {
      int index = contacts.FindIndex(c =>
          c.FirstName == firstName && c.LastName == lastName);

      if (index == -1)
        return false;

      contacts.RemoveAt(index);
      contacts.Add(updatedContact);

      return true;
    }

    public bool DeleteContact(string firstName, string lastName)
    {
      int index = contacts.FindIndex(c =>
          c.FirstName == firstName && c.LastName == lastName);

      if (index == -1)
        return false;

      contacts.RemoveAt(index);
      return true;
    }

    public MyList<Contact> SearchByCity(string city)
    {
      MyList<Contact> result = new MyList<Contact>();

      for (int i = 0; i < contacts.Count(); i++)
      {
        Contact contact = contacts.Get(i);

        if (contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
        {
          result.Add(contact);
        }
      }

      return result;
    }

    public MyList<Contact> SearchByState(string state)
    {
      MyList<Contact> result = new MyList<Contact>();

      for (int i = 0; i < contacts.Count(); i++)
      {
        Contact contact = contacts.Get(i);

        if (contact.State.Equals(state, StringComparison.OrdinalIgnoreCase))
        {
          result.Add(contact);
        }
      }

      return result;
    }

    private void AddToCityIndex(Contact contact)
    {
      if (!cityIndex.ContainsKey(contact.City))
      {
        cityIndex.Add(contact.City, new MyList<Contact>());
      }

      cityIndex.Get(contact.City).Add(contact);
    }

    private void AddToStateIndex(Contact contact)
    {
      if (!stateIndex.ContainsKey(contact.State))
      {
        stateIndex.Add(contact.State, new MyList<Contact>());
      }

      stateIndex.Get(contact.State).Add(contact);
    }

    public MyList<Contact> ViewByCity(string city)
    {
      if (!cityIndex.ContainsKey(city))
        return new MyList<Contact>();

      return cityIndex.Get(city);
    }

    public MyList<Contact> ViewByState(string state)
    {
      if (!stateIndex.ContainsKey(state))
        return new MyList<Contact>();

      return stateIndex.Get(state);
    }

    public int CountByCity(string city)
    {
      if (!cityIndex.ContainsKey(city))
        return 0;

      return cityIndex.Get(city).Count();
    }

    public int CountByState(string state)
    {
      if (!stateIndex.ContainsKey(state))
        return 0;

      return stateIndex.Get(state).Count();
    }

    public MyList<Contact> SortByName()
    {
      MyList<Contact> sorted = contacts.Clone();

      for (int i = 0; i < sorted.Count() - 1; i++)
      {
        for (int j = 0; j < sorted.Count() - i - 1; j++)
        {
          Contact c1 = sorted.Get(j);
          Contact c2 = sorted.Get(j + 1);

          string name1 = c1.FirstName + c1.LastName;
          string name2 = c2.FirstName + c2.LastName;

          if (string.Compare(name1, name2, StringComparison.OrdinalIgnoreCase) > 0)
          {
            sorted.Set(j, c2);
            sorted.Set(j + 1, c1);
          }
        }
      }

      return sorted;
    }

    public MyList<Contact> SortByCity()
    {
      MyList<Contact> sorted = contacts.Clone();

      for (int i = 0; i < sorted.Count() - 1; i++)
      {
        for (int j = 0; j < sorted.Count() - i - 1; j++)
        {
          Contact c1 = sorted.Get(j);
          Contact c2 = sorted.Get(j + 1);

          if (string.Compare(c1.City, c2.City, StringComparison.OrdinalIgnoreCase) > 0)
          {
            sorted.Set(j, c2);
            sorted.Set(j + 1, c1);
          }
        }
      }

      return sorted;
    }

    public MyList<Contact> SortByState()
    {
      MyList<Contact> sorted = contacts.Clone();

      for (int i = 0; i < sorted.Count() - 1; i++)
      {
        for (int j = 0; j < sorted.Count() - i - 1; j++)
        {
          Contact c1 = sorted.Get(j);
          Contact c2 = sorted.Get(j + 1);

          if (string.Compare(c1.State, c2.State, StringComparison.OrdinalIgnoreCase) > 0)
          {
            sorted.Set(j, c2);
            sorted.Set(j + 1, c1);
          }
        }
      }

      return sorted;
    }

    public MyList<Contact> SortByZip()
    {
      MyList<Contact> sorted = contacts.Clone();

      for (int i = 0; i < sorted.Count() - 1; i++)
      {
        for (int j = 0; j < sorted.Count() - i - 1; j++)
        {
          Contact c1 = sorted.Get(j);
          Contact c2 = sorted.Get(j + 1);

          if (string.Compare(c1.Zip, c2.Zip) > 0)
          {
            sorted.Set(j, c2);
            sorted.Set(j + 1, c1);
          }
        }
      }

      return sorted;
    }


  }
}
