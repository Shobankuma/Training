using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class Objects
    {
        public void Run()
        {
            {
                //Creating object
                Calculator calObject = new Calculator();

                //Accessing Calculator class member using Calculator class object
                int result = calObject.CalculateSum(30, 20);

                Console.WriteLine(result);
                Console.ReadKey();
            }
        }

        //Defining class or blueprint or template
        public class Calculator
        {
            public int CalculateSum(int no1, int no2)
            {
                return no1 + no2;
            }
        }
    }
}
