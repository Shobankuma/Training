using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    public delegate void RectDelegate(double width, double hight);
    internal class MulticastDelegates
    {
        public void Run()
        {
            Rectanglee rectanglee = new Rectanglee();
            RectDelegate obj = rectanglee.GetArea;  //binding method
            obj += rectanglee.GetPerimeter;
            obj(10, 20);  // or obj.Invoke(10,20) we can use invoke method
            
            rectanglee.GetPerimeter(10, 20);
        }
    }
    class Rectanglee
    {
        public void GetArea(double width, double hight)
        {
            Console.WriteLine(width * hight);
        }
        public void GetPerimeter(double width, double hight)
        {
            Console.WriteLine(width + hight);
        }
    }
}
