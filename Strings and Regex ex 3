using System;
using System.Text.RegularExpressions;

class Exercise16
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = DecimalDigitInformation(input);
        Console.WriteLine(result);
    }

    static string DecimalDigitInformation(string input)
    {
        Match match = Regex.Match(input, @"\\d|\\d");

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                return $"Digit {input[i]} at position {i}";
            }
        }

        return "No digit found!";
    }
}
