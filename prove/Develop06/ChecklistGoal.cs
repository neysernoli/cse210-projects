public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
          _amountCompleted = 0;
          _target = target;
          _bonus = bonus;
    }
    public int Bonus => _bonus;

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Objective Completed! {GetDetailsString()} + {_points + _bonus} points earned."); 
        }
        else 
        {
            Console.WriteLine($"events recorded for{GetDetailsString()} + {_points} points earned. Progress: {_amountCompleted}/{_target}");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"[] {status} {GetDetailsString()} - Completed {_amountCompleted}/{_target} times";
    }
}