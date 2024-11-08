using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ImplicitTypecasting
    {
        public void Run()
        {
            int intValue = 100;

            double doubleValue = intValue; // Implicit cast
            Console.WriteLine("double value: " + doubleValue);

            long longValue = intValue; // Implicit cast
            Console.WriteLine("long value: " + longValue);

            float floatValue = intValue; // Implicit cast
            Console.WriteLine("float value: " + floatValue);

            decimal decimalValue = intValue; // Implicit cast
            Console.WriteLine("decimal value: " + decimalValue);
        }
    }
}
