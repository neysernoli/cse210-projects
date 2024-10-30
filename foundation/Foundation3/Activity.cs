public class Activity
{
    private DateTime _date;
    private int _duration; 

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date => _date;
    public int Duration => _duration;

    public virtual double GetDistance()
    {
      return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
      return $"{_date.ToShortDateString()} {GetType().Name} ({_duration} min)- Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}