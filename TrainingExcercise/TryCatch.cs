using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class TryCatch
    {
        public void Run() {
            try
            {
                int num1 = 10;
                int num2 = 0;  // Division by zero
                int result = num1 / num2;  // This will throw an exception
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: Cannot divide by zero." + e.Message);
            }
            finally
            {
                Console.WriteLine("This block will always execute");
            }
    }

    }
}
