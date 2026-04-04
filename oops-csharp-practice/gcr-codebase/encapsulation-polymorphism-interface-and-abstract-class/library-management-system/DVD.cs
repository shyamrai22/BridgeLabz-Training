using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.library_management_system
{
    public class DVD : LibraryItem, IReservable
    {
        private string borrowerName;

        public DVD(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem(string borrowerName)
        {
            if (!isAvailable)
            {
                Console.WriteLine("DVD already reserved.");
                return;
            }

            this.borrowerName = borrowerName;
            isAvailable = false;
            Console.WriteLine("DVD reserved successfully.");
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}
