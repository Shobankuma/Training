using System;


namespace TrainingExcercise
{
    internal class ArithmeticOperators
    {
        public void Run()
        {
            double num1, num2;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("\nSelect an operator:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Modulus (%)");
            Console.WriteLine("6. Exponentiation (^)");

            Console.Write("\nEnter your choice (1-6): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nAddition: {0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("\nSubtraction: {0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("\nMultiplication: {0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    // Handling division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine("\nDivision: {0} / {1} = {2}", num1, num2, num1 / num2);
                    }
                    break;
                case 5:
                    Console.WriteLine("\nModulus: {0} % {1} = {2}", num1, num2, num1 % num2);
                    break;
                case 6:
                    Console.WriteLine("\nExponentiation: {0} ^ {1} = {2}", num1, num2, Math.Pow(num1, num2));
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select a number between 1 and 6.");
                    break;
            }
        }
    }
}
