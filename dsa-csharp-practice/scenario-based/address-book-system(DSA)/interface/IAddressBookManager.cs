using AddressBookSystem.model;
using AddressBookSystem.ds;

namespace AddressBookSystem.interface_layer
{
  public interface IAddressBookManager
  {
    bool AddAddressBook(string name);
    AddressBook GetAddressBook(string name);

    MyList<Contact> SearchByCityAcrossBooks(string city);
    MyList<Contact> SearchByStateAcrossBooks(string state);
  }
}
