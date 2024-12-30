using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LinqSorting
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 10, 1, 5, 3, 8, 7, 4, 2, 9, 6 };

        // Sorting using LINQ
        var sortedNumbers = numbers.OrderBy(num => num);  // Ascending order
        var sortedDescendingNumbers = numbers.OrderByDescending(num => num);  // Descending order

        Console.WriteLine("Sorted Ascending:");
        foreach (var num in sortedNumbers)
        {
            Console.WriteLine(num);
        }

    Console.WriteLine("Sorted Descending:");
        foreach (var num in sortedDescendingNumbers)
        {
            Console.WriteLine(num);
        }
    }

    }
}
