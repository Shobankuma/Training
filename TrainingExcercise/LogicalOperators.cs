using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class LogicalOperators
    {
        public void Run()
        {
            bool condition1, condition2;

           
            Console.WriteLine("Enter the first condition (true/false): ");
            condition1 = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter the second condition (true/false): ");
            condition2 = Convert.ToBoolean(Console.ReadLine());

           
            Console.WriteLine($"\nEvaluating logical operators between {condition1} and {condition2}:");

            
            Console.WriteLine($"{condition1} && {condition2} : {condition1 && condition2}");

            
            Console.WriteLine($"{condition1} || {condition2} : {condition1 || condition2}");

            
            Console.WriteLine($"!{condition1} : {!condition1}");
            Console.WriteLine($"!{condition2} : {!condition2}");
        }
    }
}
