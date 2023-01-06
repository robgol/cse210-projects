using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
       
       while (play == "yes")
       {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess = 0;
            int attempts = 0;
            
            do
            {
                attempts++;
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (number == guess)
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts!");
                    Console.Write($"Do you want to play again?(yes/no) ");
                    play = Console.ReadLine();
                }

                if (number < guess)
                Console.WriteLine($"Lower");
                
                if (number > guess)
                Console.WriteLine($"Higher");
            
            } while (number != guess);
       }
    }
}