using System;

class Program
{
    static void Main(string[] args)
    {
        //add a random scriptures to the user!!
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),
            new Scripture(new Reference("Mosiah", 3, 19), "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble.")
        };

        Random rand = new Random();
        int randomIndex = rand.Next(scriptures.Count);

        Scripture randomScripture = scriptures[randomIndex];

        Console.Clear();
        Console.WriteLine(randomScripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            randomScripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());

            if (randomScripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. The program will now exit.");
                break;
            }
        }        
    }
}