using System.Collections.Generic;

using AddressBook.Interfaces;
using AddressBook.Exceptions;

namespace AddressBook.Services
{
  public class AddressBookSystem : IAddressBookSystem
  {
    private readonly Dictionary<string, AddressBookService> books = new();

    // UC6
    public void AddAddressBook(string name)
    {
      if (books.ContainsKey(name))
      {
        throw new DuplicateContactException(
            "Address Book already exists."
        );
      }

      books[name] = new AddressBookService();
    }

    public IAddressBook GetAddressBook(string name)
    {
      if (!books.ContainsKey(name))
      {
        throw new ContactNotFoundException(
            "Address Book not found."
        );
      }

      return books[name];
    }

    public Dictionary<string, IAddressBook> GetAllAddressBooks()
    {
      Dictionary<string, IAddressBook> result = new();

      foreach (var item in books)
      {
        result[item.Key] = item.Value;
      }

      return result;
    }
  }
}
