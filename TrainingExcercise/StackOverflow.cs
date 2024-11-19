using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class StackOverflow
    {
        public void Run()
        {
            static void RecursiveMethod()
            {
                // This will cause infinite recursion
                RecursiveMethod();
            }
            try
            {
                RecursiveMethod(); // Start the infinite recursion
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Stack overflow exception caught: " + e.Message);
            }
        }
    }
}
