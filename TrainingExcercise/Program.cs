using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrainingExcercise;

internal class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Select a program to run:");
            Console.WriteLine("1. HelloWorld");
            Console.WriteLine("2. ExplicitTypecasting");
            Console.WriteLine("3. ImplicitTypecasting");
            Console.WriteLine("4. BitManipulation");
            Console.WriteLine("5. AdditionalOperators");
            Console.WriteLine("6. RelationalOperators");
            Console.WriteLine("7. LogicalOperators");
            Console.WriteLine("8. BitwiseOperators");
            Console.WriteLine("9. AssignmentOperators");
            Console.WriteLine("10. Miscellaneous Operators");
            Console.WriteLine("11. IfStatement");
            Console.WriteLine("12. IfElseStatement");
            Console.WriteLine("13. ForLoop");
            Console.WriteLine("14. ForEachLoop");
            Console.WriteLine("15. Whileloop");
            Console.WriteLine("16. DoWhileLoop");
            Console.WriteLine("17. Trycatchfinally");
            Console.WriteLine("18. ThrowException");
            Console.WriteLine("19. Objects");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HelloWorld helloworld = new HelloWorld();
                    helloworld.Run();
                    break;

                case "2":
                    ExplicitTypecasting explicitTypecasting = new ExplicitTypecasting();
                    explicitTypecasting.Run();
                    explicitTypecasting = new ExplicitTypecasting(1);
                    Console.WriteLine($"{explicitTypecasting.b}");
                    break;

                case "3":
                    ImplicitTypecasting implicitTypecasting = new ImplicitTypecasting();
                    implicitTypecasting.Run();
                    break;


                case "4":
                    BitManipulation bitManipulation = new BitManipulation();
                    bitManipulation.Run();
                    break;

                case "5":
                   ArithmeticOperators arithmeticOperators = new ArithmeticOperators();
                    arithmeticOperators.Run();
                    break;

                case "6":
                    RelationalOperators relationalOperators = new RelationalOperators();
                    relationalOperators.Run();
                    break;

                case "7":
                    LogicalOperators logicalOperators = new LogicalOperators();
                    logicalOperators.Run();
                    break;

                case "8":
                    BitwiseOperators bitwiseOperators = new BitwiseOperators();
                    bitwiseOperators.Run();
                    break;

                case "9":
                    AssignmentOperators assignmentOperators = new AssignmentOperators();
                    assignmentOperators.Run();
                    break;

                case "10":
                    MiscellaneousOperators miscellaneousOperators = new MiscellaneousOperators();
                    miscellaneousOperators.Run();
                    break;

                case "11":
                    IfStatement ifStatement = new IfStatement();
                    ifStatement.Run();
                    break;

                case "12":
                    Elseif elseifStatement = new Elseif();
                    elseifStatement.Run();
                    break;

                case "13":
                    Forloop forloop = new Forloop();
                    forloop.Run(); break;

                case "14":
                    ForEachLoop forEachLoop = new ForEachLoop();
                    forEachLoop.Run(); break;

                case "15":
                    Whileloop whileloop = new Whileloop();
                    whileloop.Run(); break;

                case "16":
                    DoWhileLoop doWhileLoop = new DoWhileLoop();
                    doWhileLoop.Run(); break;

                case "17":
                    TryCatch tryCatch = new TryCatch();
                    tryCatch.Run(); break;

                case "18":
                    ThrowException throwException = new ThrowException();
                    throwException.Run(); break;

                case "19":
                    Objects objects = new Objects();
                    objects.Run(); break;   

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }

    }
}
