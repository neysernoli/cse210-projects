public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 60)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessege();
        ShowSpinner(3);
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(3);
        GetListFromUser(_duration);
        DisplayEndingMessege();
        ShowMotivationalMessage();
        ShowSpinner(1);

    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"---{_prompts[index]}---");
    }
    public List<string> GetListFromUser(int availableTime)
    {
        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(availableTime);
        while (DateTime.Now < endTime)
        {
        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            userItems.Add(input);
        }
        }
        return userItems;
    }    
}