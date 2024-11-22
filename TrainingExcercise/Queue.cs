using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class Queue
    {
        public void Run()
        {
            // Declare and initialize a Queue of integers
            Queue<int> queue = new Queue<int>();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Dequeue elements
            Console.WriteLine("Dequeued: " + queue.Dequeue());  // Removes 10
            Console.WriteLine("Dequeued: " + queue.Dequeue());  // Removes 20

            // Peek at the front element
            Console.WriteLine("Front element: " + queue.Peek());  // 30

            // Remaining elements in the queue
            Console.WriteLine("\nRemaining elements in the queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

    }
}
