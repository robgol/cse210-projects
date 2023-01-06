using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input;
        do
        {
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
                break;
            
            numbers.Add(input);

        } while (true);

        int sum, largest, smallestPositiveNumber, number;
        sum = largest = smallestPositiveNumber = 0;
        
        for (int i = 0; i < numbers.Count; i++)
        {
            number = numbers[i];
            if (i == 0)
                sum = largest = smallestPositiveNumber = number;
            else
            {
                sum += number;
                
                if (number > largest)
                    largest = number;

                if (number < smallestPositiveNumber && number > 0)
                    smallestPositiveNumber = number;
            }
        }

        float avg = sum / numbers.Count;
        
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine($"The sorted list is:");
        
        foreach ( int i in numbers)
        {
            Console.WriteLine(i);
        }
        
    }
}