using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int numberg = 0;

        while (numberg != number)
        {
            Console.Write("What is your guess? ");
            numberg = int.Parse(Console.ReadLine());
            
            if (numberg > number)
            {
                Console.WriteLine("Lower");
            }
            else if (numberg < number)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}