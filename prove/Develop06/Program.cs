class Program
{
    static void Main(string[] args)
    {
        Manager goalManager = new Manager();

        // Menu for user interaction
        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Display goals");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Choose the type of goal:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Choose an option: ");
                    string goalType = Console.ReadLine();
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter goal description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter goal points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "1")
                    {
                        goalManager.AddGoal(new SimpleGoal(name, description, points));
                    }
                    else if (goalType == "2")
                    {
                        goalManager.AddGoal(new EternalGoal(name, description, points));
                    }
                    else if (goalType == "3")
                    {
                        Console.Write("Enter target times: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        goalManager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                    }
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter the name of the goal: ");
                    string goalName = Console.ReadLine();
                    goalManager.RecordEvent(goalName);
                    break;
                case "4":
                    goalManager.SaveGoals("goals.txt");
                    break;
                case "5":
                    goalManager.LoadGoals("goals.txt");
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}