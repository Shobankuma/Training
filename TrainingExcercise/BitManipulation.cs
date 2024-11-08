using System;

namespace TrainingExcercise
{
    internal class BitManipulation
    {
        public void Run()
        {
            Console.Write("Enter a bit position: ");
            int bit = Convert.ToInt32(Console.ReadLine());
            int result = 1 << bit; 


            Console.WriteLine($"Number with only the {bit} bit set to 1:");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));


        }
    }
}