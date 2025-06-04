using System;

class Exercise25
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        bool keepGoing = true;

        while (keepGoing)
        {
            try
            {
                Console.Write("Enter index of the element you want to see: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Element at index {index}: {numbers[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index out of range.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid number format.");
            }

            Console.Write("Do you want to try another? (y/n): ");
            string response = Console.ReadLine();
            keepGoing = response.ToLower() == "y";
        }
    }
}
