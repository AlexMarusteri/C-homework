using System;

class Exercise7
{
    static void Main()
    {
        Console.Write("Number to convert: ");
        int number = int.Parse(Console.ReadLine());

        string binary = "";
        int n = number;

        if (n == 0)
        {
            binary = "0";
        }
        else
        {
            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }
        }

        Console.WriteLine("Binary: " + binary);
    }
}
