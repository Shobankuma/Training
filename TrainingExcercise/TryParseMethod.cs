using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class TryParseMethod
    {
        public void Run() { 
            string validNumberString = "456";
            string invalidNumberString = "abc";

            // Using TryParse to safely convert a valid string
            if (int.TryParse(validNumberString, out int validNumber))
            {
                Console.WriteLine("Conversion succeeded: " + validNumber);  // Output: Conversion succeeded: 456
            }
            else
            {
                Console.WriteLine("Conversion failed for: " + validNumberString);
            }

            // Using TryParse to safely convert an invalid string
            if (int.TryParse(invalidNumberString, out int invalidNumber))
            {
                Console.WriteLine("Conversion succeeded: " + invalidNumber);
            }
            else
            {
                Console.WriteLine("Conversion failed for: " + invalidNumberString);  // Output: Conversion failed for: abc
            }
        }
    }
}

