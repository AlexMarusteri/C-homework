using System;

class Exercise5
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int alphabets = 0;
        int digits = 0;
        int specialChars = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
                alphabets++;
            else if (char.IsDigit(c))
                digits++;
            else
                specialChars++;
        }

        Console.WriteLine("Number of Alphabets in the string is : " + alphabets);
        Console.WriteLine("Number of Digits in the string is : " + digits);
        Console.WriteLine("Number of Special characters in the string is : " + specialChars);
    }
}
