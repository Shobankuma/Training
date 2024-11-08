using System;

namespace TrainingExcercise
{
    internal class BitwiseOperators
    {
        public void Run()
        {
            int num1, num2;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nChoose a bitwise operator:");
            Console.WriteLine("1. Bitwise AND (&)");
            Console.WriteLine("2. Bitwise OR (|)");
            Console.WriteLine("3. Bitwise XOR (^)");
            Console.WriteLine("4. Bitwise NOT (~) - Unary");
            Console.WriteLine("5. Left Shift (<<)");
            Console.WriteLine("6. Right Shift (>>)");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    Console.WriteLine($"\n{num1} & {num2} = {num1 & num2}");
                    break;

                case 2: 
                    Console.WriteLine($"\n{num1} | {num2} = {num1 | num2}");
                    break;

                case 3: 
                    Console.WriteLine($"\n{num1} ^ {num2} = {num1 ^ num2}");
                    break;

                case 4: 
                    Console.WriteLine($"\n~{num1} = {~num1}");
                    Console.WriteLine($"~{num2} = {~num2}");
                    break;

                case 5: 
                    Console.WriteLine($"\n{num1} << 1 = {num1 << 1}");
                    Console.WriteLine($"{num2} << 1 = {num2 << 1}");
                    break;

                case 6: 
                    Console.WriteLine($"\n{num1} >> 1 = {num1 >> 1}");
                    Console.WriteLine($"{num2} >> 1 = {num2 >> 1}");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please choose a valid option.");
                    break;
            }
        }
    }
}
