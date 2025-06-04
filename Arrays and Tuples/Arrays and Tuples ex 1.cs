using System;

class Exercise11
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

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("Sum of all elements stored in the array is : " + sum);
    }
}
