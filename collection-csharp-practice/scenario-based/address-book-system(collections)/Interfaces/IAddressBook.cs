using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Interfaces
{
  public interface IAddressBook
  {
    void AddContact(Contact contact);

    void EditContact(string firstName, string lastName);

    void DeleteContact(string firstName, string lastName);

    List<Contact> GetAllContacts();

    List<Contact> SearchByCity(string city);

    List<Contact> SearchByState(string state);

    int CountByCity(string city);

    int CountByState(string state);

    List<Contact> SortByName();

    List<Contact> SortByCity();

    List<Contact> SortByState();

    List<Contact> SortByZip();

  }
}
