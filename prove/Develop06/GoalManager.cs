public class Manager
{
    private List<Goal> _goals;
    private int _totalScore;
    

    public Manager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Meta '{goal.Name}' añadida exitosamente.");
    }
    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.Find(g => g.Name == goalName);

        if (goal != null)
        {
            goal.RecordEvent();
            int pointsEarnd = goal.Points;

            if(goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                pointsEarnd += checklistGoal.Bonus;
            }

            _totalScore += pointsEarnd;
            Console.WriteLine($"Update total score:{_totalScore} points.");
        } 
        else
        {
            Console.WriteLine($"Goal '{goalName}' was not found.");
        }
    }
    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals List:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine($"Total score: {_totalScore} points.");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("goals loaded successfully.");
    }

    public void LoadGoals(string filePath)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filePath))
        {
            _totalScore = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line); 
            }
            }
        Console.WriteLine("Goals loaded successfully.");
    }
}
