using System;

namespace BridgeLabzTraining.oops_csharp_practice.inheritance
{

    // Superclass
    class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }


    // Subclass Dog
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("barks");
        }
    }

    // Subclass Cat
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("meows");
        }
    }

    // Subclass Bird
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("chirps");
        }
    }

    // Caller class
    class Caller
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog("Byte", 2);
            Animal cat = new Cat("Kate", 3);
            Animal bird = new Bird("Patrick", 1);

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
        }
    }
}
