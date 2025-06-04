using System;

class Exercise24
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException() : base("Temperature is zero!") { }
    }

    public class Temperature
    {
        public int Value { get; set; }

        public void Display()
        {
            if (Value == 0)
                throw new TempIsZeroException();
            Console.WriteLine("Temperature: " + Value);
        }
    }

    static void Main()
    {
        try
        {
            Temperature temp = new Temperature();
            Console.Write("Enter temperature: ");
            temp.Value = int.Parse(Console.ReadLine());
            temp.Display();
        }
        catch (TempIsZeroException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
}
