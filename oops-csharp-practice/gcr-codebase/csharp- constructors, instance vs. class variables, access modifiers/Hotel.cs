using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Hotel
    {
        private string guestName;
        private string roomType;
        private int nights;

        // default constructor
        public Hotel() : this("Na", "Na", 2)
        {
        }

        // copy constructor
        public Hotel(Hotel room)
        {
            guestName = room.guestName;
            roomType = room.roomType;
            nights = room.nights;
        }

        // parameterised constructor
        public Hotel(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;   
            this.nights = nights;   
        }

        // method to display fields
        public void Display()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Guest Name --> {guestName}");
            Console.WriteLine($"Room Type --> {roomType}");
            Console.WriteLine($"Nights --> {nights}");
            Console.WriteLine("===================");
        }
    }


    // class with main method
    class Caller
    {
        public static void Main(string[] args)
        {
            Hotel room1 = new Hotel();
            Hotel room2 = new Hotel(room1);
            Hotel room3 = new Hotel("Shyam","Suit",5);

            room1.Display();
            room2.Display();
            room3.Display();
        }
    }
}
