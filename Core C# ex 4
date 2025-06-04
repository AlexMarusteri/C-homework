using System;

class Exercise8
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, x, /): ");
        string op = Console.ReadLine();

        double result;
        switch (op)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;
            case "x":
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;
            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Unrecognized character");
                break;
        }
    }
}
