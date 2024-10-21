using System.Formats.Asn1;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Brathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessege(); 

        ShowSpinner(2);

        int totalCycles = _duration / 10;

        for (int i = 0; i < _duration / 10; i++ )
        {
          Console.Write("Breathe in...");
          ShowCountDown(4);
          Console.Write("Now breathe out...");
          ShowCountDown(6);
          Console.WriteLine(" ");
        }

        DisplayEndingMessege();
        ShowMotivationalMessage();
        ShowSpinner(1);

    }
}