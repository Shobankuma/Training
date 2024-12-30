using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LinqFiltering
    {
        public void Run()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

        // Using Where to filter
        var filteredNames = names.Where(name => name.StartsWith("A"));

        foreach (var name in filteredNames)
        {
            Console.WriteLine(name);
        }
}

    }
}
