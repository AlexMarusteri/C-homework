using System;

class Exercise10
{
    static void Main()
    {
        Console.Write("Enter base number: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = int.Parse(Console.ReadLine());

        long result = ToThePowerOf(baseNum, exponent);
        Console.WriteLine("Result: " + result);
    }

    static long ToThePowerOf(int baseNum, int exponent)
    {
        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        return result;
    }
}
