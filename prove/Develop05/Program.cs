using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == "2")
            {                   
                ReflectingActivity reflectingActivity = new ReflectingActivity(5);
                reflectingActivity.Run();
            }
            else if (choice =="3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();

            }
            else if (choice == "4")
            {
                Console.WriteLine("Thanks for taking a time to meditate.");
                break;
            }
        }
    }

    
}