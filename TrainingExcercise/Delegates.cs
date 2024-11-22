using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class Delegates
    { 
        // Define the delegate type
        delegate void GreetDelegate(string name);

        public void Run()
        {
            // Instantiate a delegate and associate it with a method
            GreetDelegate greet = new GreetDelegate(SayHello);

            // Invoke the delegate
            greet("Alice");

            // Delegate can also reference another method
            GreetDelegate greet2 = new GreetDelegate(SayGoodbye);
            greet2("Bob");
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name);
        }
    }

}
