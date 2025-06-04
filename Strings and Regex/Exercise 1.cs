using System;

class Exercise14
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        string result = MixTwoStrings(str1, str2);
        Console.WriteLine("Mixed string: " + result);
    }

    static string MixTwoStrings(string s1, string s2)
    {
        string result = "";
        int maxLength = Math.Max(s1.Length, s2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < s1.Length)
                result += s1[i];
            if (i < s2.Length)
                result += s2[i];
        }

        return result;
    }
}
