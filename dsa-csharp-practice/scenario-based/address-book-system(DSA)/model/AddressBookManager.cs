using AddressBookSystem.ds;

namespace AddressBookSystem.model
{
  public class AddressBookManager
  {
    private MyDictionary<string, AddressBook> addressBooks;

    public AddressBookManager()
    {
      addressBooks = new MyDictionary<string, AddressBook>();
    }

    public bool AddAddressBook(string name)
    {
      if (string.IsNullOrWhiteSpace(name))
        return false;

      if (addressBooks.ContainsKey(name))
        return false;

      addressBooks.Add(name, new AddressBook());
      return true;
    }

    public AddressBook GetAddressBook(string name)
    {
      if (!addressBooks.ContainsKey(name))
        throw new Exception("Address Book not found.");

      return addressBooks.Get(name);
    }

    public MyList<Contact> SearchByCityAcrossBooks(string city)
    {
      MyList<Contact> result = new MyList<Contact>();

      var keys = addressBooks.GetAllKeys();

      foreach (var key in keys)
      {
        AddressBook book = addressBooks.Get(key);
        MyList<Contact> matches = book.SearchByCity(city);

        for (int i = 0; i < matches.Count(); i++)
        {
          result.Add(matches.Get(i));
        }
      }

      return result;
    }

    public MyList<Contact> SearchByStateAcrossBooks(string state)
    {
      MyList<Contact> result = new MyList<Contact>();

      var keys = addressBooks.GetAllKeys();

      foreach (var key in keys)
      {
        AddressBook book = addressBooks.Get(key);
        MyList<Contact> matches = book.SearchByState(state);

        for (int i = 0; i < matches.Count(); i++)
        {
          result.Add(matches.Get(i));
        }
      }

      return result;
    }

  }
}
