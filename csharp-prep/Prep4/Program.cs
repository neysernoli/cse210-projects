using System;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        Console.WriteLine("Enter a list of number, type 0 when finished.");
        
        int numberu = -1; 

        while (numberu != 0)
        {
            Console.Write("Enter number: ");
            string numberUser = Console.ReadLine();
            numberu = int.Parse(numberUser);

            if (numberu != 0)
            {
                numbers.Add(numberu);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");







    }
}