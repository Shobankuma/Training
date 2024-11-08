using System;


namespace TrainingExcercise
{
    internal class MiscellaneousOperators
    {
        public void Run()
        {
            int num1, num2;
            string input;

           
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Enter a string (leave empty for null example): ");
            input = Console.ReadLine();

            
            Console.WriteLine("\nChoose a miscellaneous operator:");
            Console.WriteLine("1. Ternary Operator (?:)");
            Console.WriteLine("2. Null-Coalescing Operator (??)");
            Console.WriteLine("3. Type-Casting (as, is)");

           
            int choice = Convert.ToInt32(Console.ReadLine());

           
            switch (choice)
            {
                case 1: 
                    int max = (num1 > num2) ? num1 : num2;
                    Console.WriteLine($"\nThe larger number is: {max}");
                    break;

                case 2: 
                    string name = input ?? "Default Name";
                    Console.WriteLine($"\nName: {name}");
                    break;

                case 3: 
                    if (num1 is double)
                    {
                        Console.WriteLine($"\nnum1 is of type int: {num1}");
                    }
                    object obj = "Hello World";
                    String str = obj as string;
                    if (str != null)
                    {
                        Console.WriteLine($"\nThe string value is: {str}");
                    }
                    else
                    {
                        Console.WriteLine("\nFailed to cast object to string.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please choose a valid option.");
                    break;
            }
        }
    }
}
