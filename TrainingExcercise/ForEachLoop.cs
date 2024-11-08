using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ForEachLoop
    {
        public void Run()
        {
            string[] names = { "Alice", "Bob", "Charlie" };
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
        }
    }
}
