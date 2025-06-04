using System;
using System.Collections.Generic;

class Exercise12
{
    static void Main()
    {
        Console.Write("Input the number of elements to be stored in the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        foreach (int num in arr)
        {
            if (num % 2 == 0)
                even.Add(num);
            else
                odd.Add(num);
        }

        Console.WriteLine("The Even elements are:");
        foreach (int e in even)
            Console.Write(e + " ");
        Console.WriteLine();

        Console.WriteLine("The Odd elements are:");
        foreach (int o in odd)
            Console.Write(o + " ");
        Console.WriteLine();
    }
}
