using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    
    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add two floating-point numbers
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add three floating-point numbers
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }

    class MethodOverloading
    {
        public void Run()
        {
            Calculator calc = new Calculator();

            // Calling different overloaded Add methods
            int result1 = calc.Add(10, 20);  // Calls Add(int, int)
            double result2 = calc.Add(10.5, 20.5);  // Calls Add(double, double)
            int result3 = calc.Add(10, 20, 30);  // Calls Add(int, int, int)
            double result4 = calc.Add(10.5, 20.5, 30.5);  // Calls Add(double, double, double)

            // Printing results
            Console.WriteLine("Sum of two integers: " + result1);  // Output: 30
            Console.WriteLine("Sum of two doubles: " + result2);  // Output: 31
            Console.WriteLine("Sum of three integers: " + result3);  // Output: 60
            Console.WriteLine("Sum of three doubles: " + result4);  // Output: 61.5
        }
    }

}

