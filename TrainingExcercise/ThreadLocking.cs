using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("C sharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented language");
            }
        }

        public void Run()
        {
            ThreadLocking obj = new ThreadLocking();
            
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }
    }
}
