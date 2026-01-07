using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.library_management_system
{
    class LibraryCaller
    {
        static void Main(string[] args)
        {
            LibraryItem[] items = new LibraryItem[5];
            int index = 0;

            items[index++] = new Book(1, "Clean Code", "Robert C. Martin");
            items[index++] = new Magazine(2, "Time", "Time Editors");
            items[index++] = new DVD(3, "Inception", "Christopher Nolan");

            Console.WriteLine("LIBRARY ITEMS");
            Console.WriteLine();

            for (int i = 0; i < index; i++)
            {
                ProcessItem(items[i]);
                Console.WriteLine("------------------------------------");
            }
        }

        static void ProcessItem(LibraryItem item)
        {
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

            if (item is IReservable reservable)
            {
                if (reservable.CheckAvailability())
                {
                    reservable.ReserveItem("User1");
                }
            }
        }
    }
}
