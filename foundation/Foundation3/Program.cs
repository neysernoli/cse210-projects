using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 03), 30, 4.8),
            new Cycling(new DateTime(2024, 11, 03), 45, 25),
            new Swimming(new DateTime(2024, 11, 03), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}