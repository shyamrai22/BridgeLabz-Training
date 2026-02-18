using System.Collections.Generic;

namespace AddressBook.Interfaces
{
  public interface IAddressBookSystem
  {
    void AddAddressBook(string name);

    IAddressBook GetAddressBook(string name);

    Dictionary<string, IAddressBook> GetAllAddressBooks();
  }
}
