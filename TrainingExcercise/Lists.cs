using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class Lists
    {
        public void Run()
        {
            // Declare and initialize a List of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Add a new element
            numbers.Add(6);

            // Accessing and printing elements by index
            Console.WriteLine("Element at index 2: " + numbers[2]);

            // Iterating over the list using a loop
            Console.WriteLine("All numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // Remove an element
            numbers.Remove(4);
            Console.WriteLine("\nAfter removing 4:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

    }
}
