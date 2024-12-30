using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrainingExcercise
{
    internal class ThreadPerformance
    {
        public static void IncrementCounter1()
        {
            long counter = 0;
            for(long i = 0; i < 10000000; i++)
                counter++;
            Console.WriteLine("IncrementCounter1: " + counter);
        }

        public static void IncrementCounter2()
        {
            long counter = 0;
            for (long i = 0; i < 10000000; i++)
                counter++;
            Console.WriteLine("IncrementCounter2: " + counter);
        }

        public void Run()
        {
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            s1.Start();
            IncrementCounter1();
            IncrementCounter2();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();

            t1.Join();
            t2.Join();

           
           
            Console.WriteLine("Time taken for Single threaded: " + s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken for Multi threaded: " + s2.ElapsedMilliseconds);

        }
    }
}
