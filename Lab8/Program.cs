using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace Lab8
{
    /* IT-1050
    Brian Kummerer
    Lab8
    */       
    class Animal  // Part1 Create Base class (parent) 
    {
        public virtual void animalSound() 
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Cat : Animal  // Part2 Create 1of2 Derived class (child) 
    {
        public override void animalSound() 
        {
            Console.WriteLine("The cat says: meow");
        }
    }

    class Dog : Animal  // Part2 Create 2of2 Derived class (child)
    {
        public override void animalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program  // Part3 Create objects referencing base class "Animal" as reference
    {
        static void Main(string[] args) 
        {
            Animal myAnimal = new Animal();  // Create a Animal object referencing "Animal" base
            Animal myCat = new Cat();        // Create a Cat object referencing "Animal" base
            Animal myDog = new Dog();        // Create a Dog object referencing "Animal" base

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();
        }
    }
}    