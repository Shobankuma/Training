using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LinqGroupBy
    {
        public void Run()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Apricot", "Blueberry", "Avocado" };

        // Grouping fruits by their first letter
        var groupedFruits = fruits.GroupBy(fruit => fruit[0]);

        foreach (var group in groupedFruits)
        {
            Console.WriteLine($"Fruits that start with {group.Key}:");
            foreach (var fruit in group)
            {
                Console.WriteLine($"  {fruit}");
            }
}
    }

    }
}
