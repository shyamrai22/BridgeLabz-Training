using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{
    // Interface
    interface Worker
    {
        void PerformDuties();
    }

    // Superclass
    class Person
    {
        public string Name;
        public int Id;

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name --> {Name}");
            Console.WriteLine($"ID   --> {Id}");
        }
    }

    // Chef
    class Chef : Person, Worker
    {
        public Chef(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Chef Duties --> Cooking and managing kitchen");
        }
    }

    // Waiter
    class Waiter : Person, Worker
    {
        public Waiter(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Waiter Duties --> Serving and assisting customers");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Person chef = new Chef("Shyam", 101);
            Person waiter = new Waiter("Satyam", 102);

            chef.DisplayInfo();
            ((Worker)chef).PerformDuties();
            Console.WriteLine("--------------------------------");
            waiter.DisplayInfo();
            ((Worker)waiter).PerformDuties();
        }
    }
}
