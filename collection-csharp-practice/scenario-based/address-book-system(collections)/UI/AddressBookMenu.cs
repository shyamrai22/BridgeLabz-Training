using System;

using AddressBook.Models;
using AddressBook.Interfaces;
using AddressBook.Services;

namespace AddressBook.UI
{
  public class AddressBookMenu
  {

    private readonly IAddressBookSystem system;

    public AddressBookMenu()
    {
      system = new AddressBookSystem();
      SeedData();

    }

    private void SeedData()
    {
      system.AddAddressBook("Personal");
      system.AddAddressBook("Work");

      var personal = system.GetAddressBook("Personal");
      var work = system.GetAddressBook("Work");

      // Personal Contacts
      personal.AddContact(new Contact(
          "Shyam", "Rai", "Street 1", "Delhi", "Delhi", "110001",
          "9999999999", "shyam@gmail.com"));

      personal.AddContact(new Contact(
          "Amit", "Kumar", "Street 2", "Delhi", "Delhi", "110002",
          "8888888888", "amit@gmail.com"));

      personal.AddContact(new Contact(
          "Neha", "Singh", "Street 3", "Mumbai", "Maharashtra", "400001",
          "7777777777", "neha@gmail.com"));

      // Work Contacts
      work.AddContact(new Contact(
          "Rahul", "Sharma", "Office 1", "Pune", "Maharashtra", "411001",
          "6666666666", "rahul@company.com"));

      work.AddContact(new Contact(
          "Priya", "Verma", "Office 2", "Bangalore", "Karnataka", "560001",
          "5555555555", "priya@company.com"));
    }


    public void Start()
    {
      while (true)
      {
        ShowMenu();

        Console.Write("Choose: ");
        int choice = int.Parse(Console.ReadLine() ?? "0");

        try
        {
          HandleChoice(choice);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
        }
      }
    }

    private void ShowMenu()
    {
      Console.WriteLine("\n===== ADDRESS BOOK =====");
      Console.WriteLine("1. Add Address Book");
      Console.WriteLine("2. Add Contact");
      Console.WriteLine("3. Edit Contact");
      Console.WriteLine("4. Delete Contact");
      Console.WriteLine("5. View Contacts");
      Console.WriteLine("6. Search by City");
      Console.WriteLine("7. Count by City");
      Console.WriteLine("8. Count by State");
      Console.WriteLine("9. Sort by Name");
      Console.WriteLine("10. Sort by City");
      Console.WriteLine("11. Sort by State");
      Console.WriteLine("12. Sort by Zip");
      Console.WriteLine("13. Exit");

    }

    private void HandleChoice(int choice)
    {
      switch (choice)
      {
        case 1:
          AddBook();
          break;

        case 2:
          AddContact();
          break;

        case 3:
          EditContact();
          break;

        case 4:
          DeleteContact();
          break;

        case 5:
          ViewContacts();
          break;

        case 6:
          SearchCity();
          break;

        case 7:
          CountCity();
          break;

        case 8:
          CountState();
          break;

        case 9:
          SortName();
          break;

        case 10:
          SortCity();
          break;

        case 11:
          SortState();
          break;

        case 12:
          SortZip();
          break;

        case 13:
          Environment.Exit(0);
          break;


        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }

    private void AddBook()
    {
      Console.Write("Book Name: ");
      string name = Console.ReadLine()!;

      system.AddAddressBook(name);

      Console.WriteLine("Address Book Created.");
    }

    private void AddContact()
    {
      var book = GetBook();

      Contact c = ReadContact();

      book.AddContact(c);

      Console.WriteLine("Contact Added.");
    }

    private void EditContact()
    {
      var book = GetBook();

      Console.Write("First Name: ");
      string f = Console.ReadLine()!;

      Console.Write("Last Name: ");
      string l = Console.ReadLine()!;

      book.EditContact(f, l);

      Console.WriteLine("Updated.");
    }

    private void DeleteContact()
    {
      var book = GetBook();

      Console.Write("First Name: ");
      string f = Console.ReadLine()!;

      Console.Write("Last Name: ");
      string l = Console.ReadLine()!;

      book.DeleteContact(f, l);

      Console.WriteLine("Deleted.");
    }

    private void ViewContacts()
    {
      var book = GetBook();

      foreach (var c in book.GetAllContacts())
      {
        Console.WriteLine(c);
      }
    }

    private void SearchCity()
    {
      var book = GetBook();

      Console.Write("City: ");
      string city = Console.ReadLine()!;

      var result = book.SearchByCity(city);

      foreach (var c in result)
      {
        Console.WriteLine(c);
      }
    }

    private IAddressBook GetBook()
    {
      Console.Write("Book Name: ");
      string name = Console.ReadLine()!;

      return system.GetAddressBook(name);
    }

    private Contact ReadContact()
    {
      Console.Write("First Name: ");
      string f = Console.ReadLine()!;

      Console.Write("Last Name: ");
      string l = Console.ReadLine()!;

      Console.Write("Address: ");
      string a = Console.ReadLine()!;

      Console.Write("City: ");
      string c = Console.ReadLine()!;

      Console.Write("State: ");
      string s = Console.ReadLine()!;

      Console.Write("Zip: ");
      string z = Console.ReadLine()!;

      Console.Write("Phone: ");
      string p = Console.ReadLine()!;

      Console.Write("Email: ");
      string e = Console.ReadLine()!;

      return new Contact(f, l, a, c, s, z, p, e);
    }

    private void CountCity()
    {
      var book = GetBook();

      Console.Write("City: ");
      string city = Console.ReadLine()!;

      int count = book.CountByCity(city);

      Console.WriteLine($"Total Contacts: {count}");
    }
    private void CountState()
    {
      var book = GetBook();

      Console.Write("State: ");
      string state = Console.ReadLine()!;

      int count = book.CountByState(state);

      Console.WriteLine($"Total Contacts: {count}");
    }

    private void SortName()
    {
      var book = GetBook();

      var list = book.SortByName();

      foreach (var c in list)
      {
        Console.WriteLine(c);
      }
    }
    private void SortCity()
    {
      var book = GetBook();

      var list = book.SortByCity();

      foreach (var c in list)
      {
        Console.WriteLine(c);
      }
    }

    private void SortState()
    {
      var book = GetBook();

      var list = book.SortByState();

      foreach (var c in list)
      {
        Console.WriteLine(c);
      }
    }
    private void SortZip()
    {
      var book = GetBook();

      var list = book.SortByZip();

      foreach (var c in list)
      {
        Console.WriteLine(c);
      }
    }

  }
}
