using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class RelationalOperators
    {
        public void Run()
        { 
        int num1, num2;

        Console.WriteLine("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        
        Console.WriteLine("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Using relational operators to compare num1 and num2
        Console.WriteLine($"\nComparing {num1} and {num2}:");

        // Equal to (==)
        Console.WriteLine($"{num1} == {num2} : {num1 == num2}");

        // Not equal to (!=)
        Console.WriteLine($"{num1} != {num2} : {num1 != num2}");

        // Greater than (>)
        Console.WriteLine($"{num1} > {num2} : {num1 > num2}");

        // Less than (<)
        Console.WriteLine($"{num1} < {num2} : {num1 < num2}");

        // Greater than or equal to (>=)
        Console.WriteLine($"{num1} >= {num2} : {num1 >= num2}");

        // Less than or equal to (<=)
        Console.WriteLine($"{num1} <= {num2} : {num1 <= num2}");
    }
}
}