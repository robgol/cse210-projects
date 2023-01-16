using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fra1 = new Fraction(1);
        Fraction fra2 = new Fraction(5);
        Fraction fra3 = new Fraction(3, 4);
        Fraction fra4 = new Fraction(1, 3);

        List<Fraction> fractions = new List<Fraction>();
        fractions.Add(fra1);
        fractions.Add(fra2);
        fractions.Add(fra3);
        fractions.Add(fra4);

        foreach (Fraction item in fractions)
        {
            Console.WriteLine(item.GetFractionString());
            Console.WriteLine(item.GertDecimalValue());
        }

    }
}