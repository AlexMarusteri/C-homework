using System;

class Exercise13
{
    static void Main()
    {
        Console.Write("Input the size of the square matrix (less than 5): ");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[size, size];
        int[,] matrix2 = new int[size, size];
        int[,] sum = new int[size, size];

        Console.WriteLine("Input elements in the first matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"element - [{i}],[{j}] : ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The First matrix is:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write(matrix1[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("The Second matrix is:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write(matrix2[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine("The Addition of two matrix is:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
