using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ThreadPrioirty
    {
        public void Run()
        {
         
                // Create threads with different priorities
                Thread thread1 = new Thread(ExecuteTask);
                thread1.Priority = ThreadPriority.Lowest; // Set the lowest priority
                thread1.Start();

                Thread thread2 = new Thread(ExecuteTask);
                thread2.Priority = ThreadPriority.Normal; // Set normal priority
                thread2.Start();

                Thread thread3 = new Thread(ExecuteTask);
                thread3.Priority = ThreadPriority.Highest; // Set the highest priority
                thread3.Start();

                // Wait for threads to complete
                thread1.Join();
                thread2.Join();
                thread3.Join();
            }

            static void ExecuteTask()
            {
                // Simulate some work
                Thread.Sleep(1000);
                Console.WriteLine($"Task executed by thread with priority: {Thread.CurrentThread.Priority}");
            }
        }

    }
