using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    public delegate string GreetingDelegate(string name);
    internal class Anonymous
    {
        public static string Greeting(string name)
        {
            return "hello" + name + "Good Morning";
        }
    
        public void Run()
        {
            GreetingDelegate obj = delegate(string name) 
            {
                return "hello" + name + "Good Morning";
            };
            string str = obj("Scot");
            Console.WriteLine(str);
        }
    }
    
}
