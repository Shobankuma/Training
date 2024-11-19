using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ConvertClass
    {
        public void Run()
        {
            string boolString = "True";
            bool isTrue = Convert.ToBoolean(boolString);
            Console.WriteLine("Converted to boolean: " + isTrue);  // Output: Converted to boolean: True


            string numberString = "123";
            int number = Convert.ToInt32(numberString);
            Console.WriteLine("Converted to int: " + number);  // Output: Converted to int: 123


            int intValue = 10;
            double doubleValue = Convert.ToDouble(intValue);
            Console.WriteLine("Converted to double: " + doubleValue);  // Output: Converted to double: 10


            int anotherNumber = 456;
            string strValue = Convert.ToString(anotherNumber);
            Console.WriteLine("Converted to string: " + strValue);  // Output: Converted to string: 456
        }
    }
}
