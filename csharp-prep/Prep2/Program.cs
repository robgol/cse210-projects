using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage? ");
        int gradePerncentage = Convert.ToInt32(Console.ReadLine());

        string sign = "";
        if (gradePerncentage % 10 > 7)
            sign = "+";
        if (gradePerncentage % 10 < 3)
            sign = "-";

        if (gradePerncentage >= 90)
            Console.Write("A");
            if (gradePerncentage % 10 < 3)
                Console.WriteLine(sign);

        else if (gradePerncentage >= 80)
        {
            Console.Write("B");
            Console.WriteLine(sign);
        }

        else if (gradePerncentage >= 70)
        {
            Console.WriteLine("C");
            Console.WriteLine(sign);
        }
        else if (gradePerncentage >= 60)
        {
            Console.WriteLine("D");
            Console.WriteLine(sign);
        }
        else
            Console.WriteLine("F");
    }
}