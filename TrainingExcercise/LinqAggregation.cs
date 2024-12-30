using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LinqAggregation
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Summing up the numbers using LINQ
        var sum = numbers.Sum();
        var avg = numbers.Average();
        var count = numbers.Count();

        Console.WriteLine($"Sum: {sum}");
    }

}
}
