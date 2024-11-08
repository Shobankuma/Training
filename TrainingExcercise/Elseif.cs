using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class Elseif
    {
        public void Run()
        { 
        int number = -23;
        // Checking different conditions
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number< 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }

    }
}
