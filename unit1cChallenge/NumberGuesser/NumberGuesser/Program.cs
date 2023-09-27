using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Try to guess a number between 1 and 10");
        int guess;

        Random random = new Random();
        int numb = random.Next(1, 11);

        do
        {
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Please enter a valid positive integer: ");
            }

            if (guess > numb)
            {
                Console.WriteLine("your guess is too big!");
            }
            else if (guess < numb)
            {
                Console.WriteLine("your guess is too low!");
            }

        } while (guess != numb);

        Console.WriteLine("Congratulations! You've guessed the correct number: " + numb);
    }
}

