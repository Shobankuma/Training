using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class MultiThreading
    {
        static void task1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Task1 " + i);
            }
            Console.WriteLine("Thread 1 is exiting");
        }

        static void task2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Task2 " + i);
                if (i == 5)
                {
                    Console.WriteLine("thread2 went to sleep");
                    Thread.Sleep(10000);
                    Console.WriteLine("thread2 awake");
                }
            }
            Console.WriteLine("Thread 2 is exiting");
        }

        static void task3()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Task3 " + i);
            }
            Console.WriteLine("Thread 3 is exiting");
        }

        public void Run()
        {
            Thread t1 = new Thread(task1);
            Thread t2 = new Thread(task2);
            Thread t3 = new Thread(task3);
           t1.Start();
           t2.Start();
           t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("main is exiting");
        }
    }
}
