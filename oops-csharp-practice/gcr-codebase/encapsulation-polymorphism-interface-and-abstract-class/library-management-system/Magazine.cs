using System;

namespace BridgeLabzTraining.oops_csharp_practice.encapsulation_polymorphism_interface_and_abstract_class.library_management_system
{
    public class Magazine : LibraryItem, IReservable
    {
        private string borrowerName;

        public Magazine(int id, string title, string author)
            : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7; 
        }

        public void ReserveItem(string borrowerName)
        {
            if (!isAvailable)
            {
                Console.WriteLine("Magazine already reserved.");
                return;
            }

            this.borrowerName = borrowerName;
            isAvailable = false;
            Console.WriteLine("Magazine reserved successfully.");
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}
