using System;

namespace BridgeLabzTraining.oops_csharp_practice.csharp_constructors__instance_vs._class_variables__access_modifiers
{
    class Person
    {
        private int age;
        private string name;

        // copy constructor
        public Person(Person person)
        {
            this.age = person.age;
            this.name = person.name;
        }

        // parameterised constructor
        public Person(int age, string name)
        {
            this.name = name;
            this.age = age;
        }

        // method to display fields
        public void Display()
        {
            Console.WriteLine("===================");
            Console.WriteLine($"Name --> {name}");
            Console.WriteLine($"Age --> {age}");
            Console.WriteLine("===================");
        }
    }
    

    // class with main method
    class Caller
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person(22,"Shyam");
            Person person2 = new Person(person1);

            person1.Display();
            person2.Display();
        }
    }
}
