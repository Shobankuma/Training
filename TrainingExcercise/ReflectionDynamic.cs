using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    internal class ReflectionDynamic
    {
        public void Run()
        {
            // Create an instance of the Person3 class
            Person3 person = new Person3 { Name = "Charlie", Age = 40 };

            // Get the MethodInfo object for the 'Greet' method
            MethodInfo greetMethod = typeof(Person3).GetMethod("Greet");

            // Invoke the method dynamically
            greetMethod.Invoke(person, null); // Output: Hello, my name is Charlie and I am 40 years old.
        }
        }
   
}
