using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
        // Base class Animal
        class Animal
            {
                public string Name;

                public void Eat()
                {
                    Console.WriteLine(Name + " is eating.");
                }
            }

            // Derived class Dog
            class Dog : Animal
            {
                public void Bark()
                {
                    Console.WriteLine(Name + " is barking.");
                }
            }
        class Inheritence
        {
        public void Run()
        {
            Dog dog = new Dog();
            dog.Name = "Buddy";  // Set the name
            dog.Eat();  // Calling the inherited method
            dog.Bark();  // Calling the Dog-specific method
        }
    }
}


