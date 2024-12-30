using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LinqMethodChaining
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Chaining LINQ Methods
        var evenNumbersDescending = numbers
                                     .Where(num => num % 2 == 0)
                                     .OrderByDescending(num => num)
                                     .Select(num => num * 2);

        foreach (var num in evenNumbersDescending)
        {
            Console.WriteLine(num);
        }
}

    }
}
