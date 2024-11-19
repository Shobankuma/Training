using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class Constructors
    {
        class Person
        {
            // Fields
            public string Name;
            public int Age;

            // Constructor to initialize fields
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Person object created: " + Name + ", " + Age);
            }

            // Method to display person details
            public void DisplayDetails()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
            }
        }

        class Program
        {
            public void Run()
            {
                Person p1 = new Person("John", 30);  // Constructor is called
                p1.DisplayDetails();  // Displays the person's details
            }
            }
        }
    }



