using System;
using System.Collections.Generic;

class Exercise2
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            if (number % 100 == 0)
                break;
        }

        Console.WriteLine("You entered:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
