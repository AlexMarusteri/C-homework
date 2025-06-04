using System;

class Exercise9
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        bool contains3 = IfNumberContains3(number);
        Console.WriteLine(contains3);
    }

    static bool IfNumberContains3(int number)
    {
        while (number > 0)
        {
            int digit = number % 10;
            if (digit == 3)
                return true;
            number /= 10;
        }
        return false;
    }
}
