using System;

class Exercise15
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool result = AlmostOnlyLetters(input);
        Console.WriteLine(result);
    }

    static bool AlmostOnlyLetters(string text)
    {
        if (string.IsNullOrEmpty(text) || !text.EndsWith("."))
            return false;

        for (int i = 0; i < text.Length - 1; i++)
        {
            char c = text[i];
            if (!char.IsLetter(c) && c != ' ')
                return false;
        }

        return true;
    }
}
