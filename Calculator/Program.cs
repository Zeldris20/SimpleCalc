using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true) // infinate loop
            {
                Console.WriteLine("Welcome to the Calculator App");
                Console.Write("Please Enter your equation: ");
                string userInput = Console.ReadLine();

                // split the input into numbers and symbols
                string[] inputParts = userInput.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);



                if (inputParts.Length != 2)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                if (!double.TryParse(inputParts[0], out double number1) || !double.TryParse(inputParts[1], out double number2))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                // Determine the operator
                char mathOperator = userInput[inputParts[0].Length];

                // perform the calculation 
                double result = 0;
                switch (mathOperator)
                {
                    case '+':
                        result = number1 + number2;
                        break;

                    case '-':
                        result = number1 - number2;
                        break;

                    case '*':
                        result = number1 * number2;
                        break;

                    case '/':
                        if (number2 == 0)
                        {
                            Console.WriteLine();
                            continue;
                        }
                        result = number1 / number2;
                        break;
                    default:
                        Console.WriteLine("invalid Operator");
                        continue;
                }
                Console.WriteLine($"Result: {result}");


                // ask the user if they want to continue
                Console.WriteLine("Do you want to perform another calculation?");
                string again = Console.ReadLine().ToLower();
                if (again != "yes")
                {
                    break;
                }
            }

        }
    }
}