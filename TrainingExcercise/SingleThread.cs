using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class SingleThread
    {
        static void task1()
        {
            for(int i =1; i< 10; i++)
            {
                Console.WriteLine("Task1" + i);
            }
        }

        static void task2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Task2" + i);
                if (i == 5)
                {
                    Console.WriteLine("Thread is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread is awake");
                }
            }

        }

        static void task3()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Task3" + i);
            }
        }
        public void Run()
        {
            task1();
            task2();
            task3();
        }
    }
}
