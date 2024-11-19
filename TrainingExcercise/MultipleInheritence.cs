using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    // Interface 1
        // Define IAnimal interface
        interface IAnimal
        {
            void Eat();  // Animal behavior: Eating
            void Sleep();  // Animal behavior: Sleeping
        }

        // Define IFlyable interface
        interface IFlyable
        {
            void Fly();  // Flyable behavior: Flying
        }

        // Bird class implementing both IAnimal and IFlyable interfaces
        class Bird : IAnimal, IFlyable
        {
            public string Name;

            // Implementing the Eat method from IAnimal interface
            public void Eat()
            {
                Console.WriteLine(Name + " is eating.");
            }

            // Implementing the Sleep method from IAnimal interface
            public void Sleep()
            {
                Console.WriteLine(Name + " is sleeping.");
            }

            // Implementing the Fly method from IFlyable interface
            public void Fly()
            {
                Console.WriteLine(Name + " is flying.");
            }
        }

        // The Inheritance class which contains the Run method
        class MultipleInheritance
        {
            // The Run method where the logic for multiple inheritance is executed
            public void Run()
            {
                // Create an object of the Bird class
                Bird bird = new Bird();
                bird.Name = "Sparrow";  // Set the name

                // Calling methods from both IAnimal and IFlyable interfaces
                bird.Eat();    // From IAnimal interface
                bird.Sleep();  // From IAnimal interface
                bird.Fly();    // From IFlyable interface
            }
        }
}




