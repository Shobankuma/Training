using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
       class Person2
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void Greet()
            {
                Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
            }
        }

        internal class ReflectionInspect
        {
        public void Run()
        {
                // Create an instance of the Person class
                Person2 person = new Person2 { Name = "Alice", Age = 25 };

                // Get the Type object for the Person class
                Type personType = typeof(Person2);

                // Inspect the properties of the class
                PropertyInfo[] properties = personType.GetProperties();
                Console.WriteLine("Properties:");
                foreach (var property in properties)
                {
                    Console.WriteLine($"- {property.Name}");
                }

                // Inspect the methods of the class
                MethodInfo[] methods = personType.GetMethods();
                Console.WriteLine("\nMethods:");
                foreach (var method in methods)
                {
                    Console.WriteLine($"- {method.Name}");
                }

                // Inspect fields (there are none in this example, but you can inspect them similarly)
                FieldInfo[] fields = personType.GetFields();
                Console.WriteLine("\nFields:");
                foreach (var field in fields)
                {
                    Console.WriteLine($"- {field.Name}");
                }
            }
        }

    }

