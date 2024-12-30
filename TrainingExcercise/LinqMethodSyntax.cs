using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LinqMethodSyntax
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Method Syntax
        var evenNumbers = numbers.Where(num => num % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
}

    }
}
