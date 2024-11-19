using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class BaseKeyword
    {
        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Animal speaks");
            }
        }
        class Dog : Animal
        {
            public override void Speak()
            {
                // Call the base class method
                base.Speak();  // Calls Animal's Speak()
                Console.WriteLine("Dog barks");
            }
        }

        class Program
        {
            public void Run()
            {
                Dog dog = new Dog();
                dog.Speak();
                // Output:
                // Animal speaks
                // Dog barks
            }
        }

    }
}
