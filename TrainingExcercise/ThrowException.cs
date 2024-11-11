using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ThrowException
    {
        public void Run() { 
        try
        {
            ValidateAge(15);  // Will throw an exception
    }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ValidateAge(int age)
{
    if (age < 18)
    {
        throw new InvalidOperationException("Age must be 18 or older.");
    }
    else
    {
        Console.WriteLine("Age is valid.");
    }
}

    }
}
