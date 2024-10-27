using System.Net;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string descrption, int points): base(name, descrption, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"[] {status} {GetDetailsString()}";
    }
}