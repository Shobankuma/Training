using System;

namespace TrainingExcercise
{
    internal class ExplicitTypecasting
    {
        public void Run()
        {
            double doubleValue = 42.5;

            int intValue = (int)doubleValue; // Truncates the decimal part
            Console.WriteLine("int value: " + intValue); 

            char charValue = (char)doubleValue; // Casts the double to a Unicode character
            Console.WriteLine("char value: " + charValue); 

            bool boolValue = doubleValue != 0; // Any non-zero number will be considered true
            Console.WriteLine("bool value: " + boolValue);
        }
    }
}
