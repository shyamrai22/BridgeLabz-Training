using AddressBookSystem.ds;
using AddressBookSystem.model;

namespace AddressBookSystem.interface_layer
{
  public interface IAddressBook
  {
    bool AddContact(Contact contact);
    bool EditContact(string firstName, string lastName, Contact updatedContact);
    bool DeleteContact(string firstName, string lastName);

    MyList<Contact> SearchByCity(string city);
    MyList<Contact> SearchByState(string state);

    MyList<Contact> ViewByCity(string city);
    MyList<Contact> ViewByState(string state);

    int CountByCity(string city);
    int CountByState(string state);

    MyList<Contact> SortByName();
    MyList<Contact> SortByCity();
    MyList<Contact> SortByState();
    MyList<Contact> SortByZip();
  }
}
