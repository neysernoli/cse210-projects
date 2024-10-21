public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessege()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the: {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session?");
        string answer = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        if (int.TryParse(answer, out int duration) && duration > 0)
        {
            _duration = duration;              
        }
        else
        {
          Console.WriteLine("Invalid");
        }
        
    }

    public void DisplayEndingMessege()
    {
        Console.WriteLine($"Great Job!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(2);
        ShowMotivationalMessage();
        ShowSpinner(1);
        //Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine(" ");
        List<char> animation = new List<char>(); 
        animation.Add('|');
        animation.Add('/');
        animation.Add('-');
        animation.Add('\\'); 

        for (int i = 0; i < seconds * 4; i++) 
        {
            Console.Write(animation[i % animation.Count]); 
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
    }
    public void ShowMotivationalMessage()
    {
       string [] messages = {
            "¡Sigue así!",
            "Piensa en algo positivo.",
            "Recuerda lo que valoras.",
            "¡Eres capaz de lograrlo!"
       };

       Random rand = new Random();
       int index = rand.Next(messages.Length);
       Console.WriteLine(messages[index]);
    }
}