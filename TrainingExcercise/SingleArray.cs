using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class SingleArray
    {
        public void Run()
        {
            // Declaring and initializing a single-dimensional array of integers
            int[] numbers = new int[5];

            // Assigning values to the array
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // Accessing and displaying the values
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

}

