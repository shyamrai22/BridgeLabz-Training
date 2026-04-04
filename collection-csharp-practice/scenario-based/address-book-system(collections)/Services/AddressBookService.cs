using System;
using System.Collections.Generic;
using System.Linq;

using AddressBook.Models;
using AddressBook.Interfaces;
using AddressBook.Exceptions;

namespace AddressBook.Services
{
  public class AddressBookService : IAddressBook
  {
    private readonly List<Contact> contacts = new();

    // UC2, UC5, UC7
    public void AddContact(Contact contact)
    {
      if (contacts.Contains(contact))
      {
        throw new DuplicateContactException(
            "Contact already exists."
        );
      }

      contacts.Add(contact);
    }

    // UC3
    public void EditContact(string firstName, string lastName)
    {
      var contact = Find(firstName, lastName);

      Console.Write("New City: ");
      contact.City = Console.ReadLine() ?? contact.City;

      Console.Write("New Phone: ");
      contact.Phone = Console.ReadLine() ?? contact.Phone;
    }

    // UC4
    public void DeleteContact(string firstName, string lastName)
    {
      var contact = Find(firstName, lastName);
      contacts.Remove(contact);
    }

    // UC1
    public List<Contact> GetAllContacts()
    {
      return new List<Contact>(contacts);
    }

    // UC8
    public List<Contact> SearchByCity(string city)
    {
      return contacts
          .Where(c => c.City.Equals(
              city,
              StringComparison.OrdinalIgnoreCase))
          .ToList();
    }

    // UC8
    public List<Contact> SearchByState(string state)
    {
      return contacts
          .Where(c => c.State.Equals(
              state,
              StringComparison.OrdinalIgnoreCase))
          .ToList();
    }

    // Helper
    private Contact Find(string first, string last)
    {
      var contact = contacts.FirstOrDefault(
          c => c.FirstName.Equals(first,
                  StringComparison.OrdinalIgnoreCase)
            && c.LastName.Equals(last,
                  StringComparison.OrdinalIgnoreCase)
      );

      if (contact == null)
      {
        throw new ContactNotFoundException(
            "Contact not found."
        );
      }

      return contact;
    }

    public int CountByCity(string city)
    {
      return contacts.Count(
          c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase)
      );
    }

    public int CountByState(string state)
    {
      return contacts.Count(
          c => c.State.Equals(state, StringComparison.OrdinalIgnoreCase)
      );
    }

    public List<Contact> SortByName()
    {
      return contacts
          .OrderBy(c => c.FirstName)
          .ThenBy(c => c.LastName)
          .ToList();
    }

    public List<Contact> SortByCity()
    {
      return contacts
          .OrderBy(c => c.City)
          .ToList();
    }

    public List<Contact> SortByState()
    {
      return contacts
          .OrderBy(c => c.State)
          .ToList();
    }

    public List<Contact> SortByZip()
    {
      return contacts
          .OrderBy(c => c.Zip)
          .ToList();
    }


  }
}
