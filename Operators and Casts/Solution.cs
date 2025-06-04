using System;

class Exercise17
{
    public class Rational
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        private void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Denominator - b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            return new Rational(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public static bool operator <(Rational a, Rational b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

        public static bool operator >(Rational a, Rational b)
        {
            return b < a;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            return !(a > b);
        }

        public static bool operator >=(Rational a, Rational b)
        {
            return !(a < b);
        }

        public static bool operator ==(Rational a, Rational b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !a.Equals(b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rational r)
            {
                return Numerator == r.Numerator && Denominator == r.Denominator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    static void Main()
    {
        Rational r1 = new Rational(1, 2);
        Rational r2 = new Rational(3, 4);

        Console.WriteLine($"r1: {r1}");
        Console.WriteLine($"r2: {r2}");

        Console.WriteLine($"r1 + r2 = {r1 + r2}");
        Console.WriteLine($"r1 - r2 = {r1 - r2}");
        Console.WriteLine($"r1 * r2 = {r1 * r2}");
        Console.WriteLine($"r1 / r2 = {r1 / r2}");

        Console.WriteLine($"r1 < r2: {r1 < r2}");
        Console.WriteLine($"r1 == r2: {r1 == r2}");
    }
}
