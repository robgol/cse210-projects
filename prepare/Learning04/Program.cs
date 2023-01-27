using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Robson", "Multipication", "7.3", "8-19");

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writeAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine();

        Console.WriteLine(writeAssignment.GetSummary());
        Console.WriteLine(writeAssignment.GetWritingInformation());

        
    }
}