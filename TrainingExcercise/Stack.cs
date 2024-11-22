using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class Stack
    {
        public void Run()
        {
            // Declare and initialize a Stack of integers
            Stack<int> stack = new Stack<int>();

            // Push elements onto the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Pop elements
            Console.WriteLine("Popped: " + stack.Pop());  // Removes 3
            Console.WriteLine("Popped: " + stack.Pop());  // Removes 2

            // Peek at the top element
            Console.WriteLine("Top element: " + stack.Peek());  // 1

            // Remaining elements in the stack
            Console.WriteLine("\nRemaining elements in the stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

    }
}
