using System;

class Exercise20
{
    static void Main()
    {
        int a = 2, b = 3;
        Console.WriteLine($"Before swap: a = {a}; b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}; b = {b}");

        string s1 = "abc", s2 = "def";
        Console.WriteLine($"Before swap: a = {s1}; b = {s2}");
        Swap(ref s1, ref s2);
        Console.WriteLine($"After swap: a = {s1}; b = {s2}");
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
