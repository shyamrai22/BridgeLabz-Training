using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.library_management_system
{
    public class Book : LibraryItem, IReservable
    {
        private string borrowerName;

        public Book(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem(string borrowerName)
        {
            if (!isAvailable)
            {
                Console.WriteLine("Book already reserved.");
                return;
            }

            this.borrowerName = borrowerName;
            isAvailable = false;
            Console.WriteLine("Book reserved successfully.");
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}
