using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class Dictionary
    {
        public void Run()
        {
            // Declare and initialize a Dictionary with string keys and integer values
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();

            // Add key-value pairs
            ageDictionary["Alice"] = 25;
            ageDictionary["Bob"] = 30;
            ageDictionary["Charlie"] = 35;

            // Access values by key
            Console.WriteLine("Alice's age: " + ageDictionary["Alice"]);

            // Iterating through the dictionary
            Console.WriteLine("\nAll entries in the dictionary:");
            foreach (var pair in ageDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            // Check if a key exists
            if (ageDictionary.ContainsKey("Bob"))
            {
                Console.WriteLine("\nBob's age is: " + ageDictionary["Bob"]);
            }
        }
    }

}

