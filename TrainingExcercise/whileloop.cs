using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class Whileloop
    {
        public void Run()
        {
            int i = 0;
            // Print numbers 0 to 4 using while loop
            while (i < 5)
            {
                Console.WriteLine(i);  // Prints 0, 1, 2, 3, 4
                i++;  // Increment i after each iteration
            }
            Console.WriteLine();
        }
}
}
