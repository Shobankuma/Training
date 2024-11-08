using System;


namespace TrainingExcercise
{
    internal class AssignmentOperators
    {
        public void Run()
        {
            int num1, num2;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("\nChoose an assignment operator:");
            Console.WriteLine("1. Simple Assignment (=)");
            Console.WriteLine("2. Add and Assign (+=)");
            Console.WriteLine("3. Subtract and Assign (-=)");
            Console.WriteLine("4. Multiply and Assign (*=)");
            Console.WriteLine("5. Divide and Assign (/=)");
            Console.WriteLine("6. Modulo and Assign (%=)");

            
            int choice = Convert.ToInt32(Console.ReadLine());

       
            switch (choice)
            {
                case 1: 
                    num1 = num2;
                    Console.WriteLine($"\nAfter simple assignment, num1 = {num1}");
                    break;

                case 2: 
                    num1 += num2; // num1 = num1 + num2
                    Console.WriteLine($"\nAfter num1 += num2, num1 = {num1}");
                    break;

                case 3:
                    num1 -= num2; // num1 = num1 - num2
                    Console.WriteLine($"\nAfter num1 -= num2, num1 = {num1}");
                    break;

                case 4: 
                    num1 *= num2; // num1 = num1 * num2
                    Console.WriteLine($"\nAfter num1 *= num2, num1 = {num1}");
                    break;

                case 5: 
                    if (num2 != 0)  // Prevent division by zero
                    {
                        num1 /= num2; // num1 = num1 / num2
                        Console.WriteLine($"\nAfter num1 /= num2, num1 = {num1}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                    }
                    break;

                case 6: 
                    if (num2 != 0)  
                    {
                        num1 %= num2; // num1 = num1 % num2
                        Console.WriteLine($"\nAfter num1 %= num2, num1 = {num1}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Modulo by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please choose a valid option.");
                    break;
            }
        }
    }
}
