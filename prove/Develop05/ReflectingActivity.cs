using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",duration)
    {
        _prompts = new List<string>
        {
            "- Think of a time when you stood up for someone else.",
            "- Think of a time when you did something really difficult.",
            "- Think of a time when you helped someone in need.",
            "- Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "-Why was this experience meaningful to you?",
            "-Have you ever done anything like this before?",
            "-How did you get started?",
            "-How did you feel when it was complete?",
            "-What made this time different than other times when you were not as successful?",
            "-What is your favorite thing about this experience?",
            "-What could you learn from this experience that applies to other situations?",
            "-What did you learn about yourself through this experience?",
            "-How can you keep this experience in mind in the future?",
        };
    }    public void Run()
{
    DisplayStartingMessege();
    ShowSpinner(4);
    DisplayPrompt();
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
    Console.Write("You may begin in:");
    ShowCountDown(4);
    Console.Clear();
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
        DisplayQuestions();
        Thread.Sleep(2000); 
    }

    Console.Clear();
    DisplayEndingMessege();
    ShowMotivationalMessage();
    ShowSpinner(1);

}


    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the fallow promopt.");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        
        Console.Write($">{GetRandomQuestion()}");
        ShowSpinner(4);
    }
}
