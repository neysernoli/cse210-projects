public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string Name => _name;          
    public string Description => _description;  
    public int Points => _points;         
    
    public virtual void RecordEvent()
    {
        
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description} puntos: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return  $"{_name}, puntos: {_points}";
    }
}