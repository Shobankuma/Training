﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrainingExcercise;
using TrainingExcercise.YourNamespace;

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
            Console.WriteLine("20. StackOverflow");
            Console.WriteLine("21. ParseMethod");
            Console.WriteLine("22. Try Parse Method");
            Console.WriteLine("23. Convert class");
            Console.WriteLine("24. Inheritence");
            Console.WriteLine("25. Multiple Inheritence");
            Console.WriteLine("26. Hirarchial Inheritence");
            Console.WriteLine("27. Multilevel Inheritence");
            Console.WriteLine("28. Method Overriding");
            Console.WriteLine("29. Polymorphism");
            Console.WriteLine("30. Method Overloading");
            Console.WriteLine("31. Encapsulation");
            Console.WriteLine("32. Abstraction");
            Console.WriteLine("33. Single array");
            Console.WriteLine("34. Multiarray");
            Console.WriteLine("35. lists");
            Console.WriteLine("36. Disctionary");
            Console.WriteLine("37. Queue");
            Console.WriteLine("38. Stack");
            Console.WriteLine("39. delegates");
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

                case "20":
                    StackOverflow stackOverflow = new StackOverflow();
                    stackOverflow.Run(); break;

                case "21":
                    ParseMethod parseMethod = new ParseMethod();
                    parseMethod.Run(); break;

                case "22":
                    TryParseMethod tryParseMethod = new TryParseMethod();
                    tryParseMethod.Run(); break;

                case "23":
                    ConvertClass convertClass = new ConvertClass();
                    convertClass.Run(); break;

                case "24":
                    Inheritence inheritence = new Inheritence();
                    inheritence.Run(); break;

                case "25":
                    MultipleInheritance multipleInheritance = new MultipleInheritance();
                    multipleInheritance.Run(); break;

                case "26":
                    HirarchialInheritance hirarchialInheritance = new HirarchialInheritance();
                    hirarchialInheritance.Run(); break;

                case "27":
                    MultilevelInheritence multilevelInheritence = new MultilevelInheritence();
                    multilevelInheritence.Run(); break;

                case "28":
                    MethodOveriding methodOveriding = new MethodOveriding();
                    methodOveriding.Run(); break;

                case "29":
                    Polymorphism polymorphism = new Polymorphism();     
                    polymorphism.Run(); break;

                case "30":
                    MethodOverloading methodOverloading = new MethodOverloading();
                    methodOverloading.Run(); break;

                case "31":
                    Encapsultion encapsultion = new Encapsultion();
                    encapsultion.Run(); break;

                case "32":
                    Abstarction abstarction = new Abstarction();
                    abstarction.Run(); break;

                case "33":
                    SingleArray singleArray = new SingleArray();
                    singleArray.Run(); break;

                case "34":
                    MultiArray multiArray = new MultiArray();   
                    multiArray.Run(); break;

                case "35":
                    Lists lists = new Lists();  
                    lists.Run(); break;

                case "36":
                    Dictionary dictionary = new Dictionary();
                    dictionary.Run(); break;

                case "37":
                    Queue queue = new Queue();
                    queue.Run(); break;

                case "38":
                    Stack stack = new Stack();
                    stack.Run(); break;

                case "39":
                    Delegates delegates = new Delegates();
                    delegates.Run(); break;

                case "40":
                    MulticastDelegates multicastDelegates = new MulticastDelegates();
                    multicastDelegates.Run(); break;

                case "41":
                    Anonymous anonymous = new Anonymous();
                    anonymous.Run(); break;



                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }

    }
}
