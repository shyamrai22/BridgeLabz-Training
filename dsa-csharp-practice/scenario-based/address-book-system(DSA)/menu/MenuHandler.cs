using System;
using AddressBookSystem.model;
using AddressBookSystem.ds;

namespace AddressBookSystem.menu
{
  public class MenuHandler
  {
    private AddressBookManager system = new AddressBookManager();
    private AddressBook currentBook;

    public void Start()
    {
      while (true)
      {
        Console.WriteLine("\n===== Address Book System =====");
        Console.WriteLine("1. Create Address Book");
        Console.WriteLine("2. Select Address Book");
        Console.WriteLine("3. Search By City (Across Books)");
        Console.WriteLine("4. Search By State (Across Books)");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            CreateAddressBook();
            break;
          case "2":
            SelectAddressBook();
            break;
          case "3":
            SearchByCity();
            break;
          case "4":
            SearchByState();
            break;
          case "5":
            return;
          default:
            Console.WriteLine("Invalid choice.");
            break;
        }
      }
    }

    private void CreateAddressBook()
    {
      Console.Write("Enter Address Book Name: ");
      string name = Console.ReadLine();

      bool result = system.AddAddressBook(name);

      Console.WriteLine(result
          ? "Address Book created successfully."
          : "Address Book already exists.");
    }

    private void SelectAddressBook()
    {
      Console.Write("Enter Address Book Name: ");
      string name = Console.ReadLine();

      try
      {
        currentBook = system.GetAddressBook(name);
        Console.WriteLine("Address Book selected.");
        AddressBookMenu();
      }
      catch
      {
        Console.WriteLine("Address Book not found.");
      }
    }

    private void AddressBookMenu()
    {
      while (true)
      {
        Console.WriteLine("\n===== Address Book Menu =====");
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Edit Contact");
        Console.WriteLine("3. Delete Contact");
        Console.WriteLine("4. View By City");
        Console.WriteLine("5. View By State");
        Console.WriteLine("6. Count By City");
        Console.WriteLine("7. Count By State");
        Console.WriteLine("8. Sort By Name");
        Console.WriteLine("9. Sort By City");
        Console.WriteLine("10. Sort By State");
        Console.WriteLine("11. Sort By Zip");
        Console.WriteLine("12. Back");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
          case "1": AddContact(); break;
          case "2": EditContact(); break;
          case "3": DeleteContact(); break;
          case "4": ViewByCity(); break;
          case "5": ViewByState(); break;
          case "6": CountByCity(); break;
          case "7": CountByState(); break;
          case "8": DisplaySorted(currentBook.SortByName()); break;
          case "9": DisplaySorted(currentBook.SortByCity()); break;
          case "10": DisplaySorted(currentBook.SortByState()); break;
          case "11": DisplaySorted(currentBook.SortByZip()); break;
          case "12":
            currentBook = null;
            return;
          default:
            Console.WriteLine("Invalid choice.");
            break;
        }
      }
    }

    private void AddContact()
    {
      Contact contact = new Contact();

      Console.Write("First Name: ");
      contact.FirstName = Console.ReadLine();

      Console.Write("Last Name: ");
      contact.LastName = Console.ReadLine();

      Console.Write("Address: ");
      contact.Address = Console.ReadLine();

      Console.Write("City: ");
      contact.City = Console.ReadLine();

      Console.Write("State: ");
      contact.State = Console.ReadLine();

      Console.Write("Zip: ");
      contact.Zip = Console.ReadLine();

      Console.Write("Phone Number: ");
      contact.PhoneNumber = Console.ReadLine();

      Console.Write("Email: ");
      contact.Email = Console.ReadLine();

      bool result = currentBook.AddContact(contact);

      Console.WriteLine(result
          ? "Contact added successfully."
          : "Duplicate contact not allowed.");
    }

    private void EditContact()
    {
      Console.Write("Enter First Name to edit: ");
      string firstName = Console.ReadLine();

      Console.Write("Enter Last Name to edit: ");
      string lastName = Console.ReadLine();

      Contact updated = new Contact
      {
        FirstName = firstName,
        LastName = lastName
      };

      Console.Write("New Address: ");
      updated.Address = Console.ReadLine();

      Console.Write("New City: ");
      updated.City = Console.ReadLine();

      Console.Write("New State: ");
      updated.State = Console.ReadLine();

      Console.Write("New Zip: ");
      updated.Zip = Console.ReadLine();

      Console.Write("New Phone Number: ");
      updated.PhoneNumber = Console.ReadLine();

      Console.Write("New Email: ");
      updated.Email = Console.ReadLine();

      bool result = currentBook.EditContact(firstName, lastName, updated);

      Console.WriteLine(result
          ? "Contact updated successfully."
          : "Contact not found.");
    }

    private void DeleteContact()
    {
      Console.Write("Enter First Name to delete: ");
      string firstName = Console.ReadLine();

      Console.Write("Enter Last Name to delete: ");
      string lastName = Console.ReadLine();

      bool result = currentBook.DeleteContact(firstName, lastName);

      Console.WriteLine(result
          ? "Contact deleted successfully."
          : "Contact not found.");
    }

    private void ViewByCity()
    {
      Console.Write("Enter City: ");
      string city = Console.ReadLine();

      MyList<Contact> results = currentBook.ViewByCity(city);
      DisplaySorted(results);
    }

    private void ViewByState()
    {
      Console.Write("Enter State: ");
      string state = Console.ReadLine();

      MyList<Contact> results = currentBook.ViewByState(state);
      DisplaySorted(results);
    }

    private void CountByCity()
    {
      Console.Write("Enter City: ");
      string city = Console.ReadLine();

      int count = currentBook.CountByCity(city);
      Console.WriteLine($"Total contacts in {city}: {count}");
    }

    private void CountByState()
    {
      Console.Write("Enter State: ");
      string state = Console.ReadLine();

      int count = currentBook.CountByState(state);
      Console.WriteLine($"Total contacts in {state}: {count}");
    }

    private void SearchByCity()
    {
      Console.Write("Enter City: ");
      string city = Console.ReadLine();

      MyList<Contact> results = system.SearchByCityAcrossBooks(city);
      DisplaySorted(results);
    }

    private void SearchByState()
    {
      Console.Write("Enter State: ");
      string state = Console.ReadLine();

      MyList<Contact> results = system.SearchByStateAcrossBooks(state);
      DisplaySorted(results);
    }

    private void DisplaySorted(MyList<Contact> list)
    {
      if (list.Count() == 0)
      {
        Console.WriteLine("No contacts found.");
        return;
      }

      for (int i = 0; i < list.Count(); i++)
      {
        Console.WriteLine(list.Get(i));
      }
    }
  }
}
