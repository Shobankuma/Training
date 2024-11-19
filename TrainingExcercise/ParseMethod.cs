using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ParseMethod
    {
        public void Run() { 
            string number = "123";
            int result = int.Parse(number); // Converts string "123" to int 123
            Console.WriteLine(result); // Output: 123

            string invalidNumber = "abc";
            try
            {
                int invalidResult = int.Parse(invalidNumber); // This will throw an exception
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message); // Output: Error: Input string was not in a correct format.
            }
        }
    }
}

