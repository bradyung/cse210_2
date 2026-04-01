public class Activity
{
    private string _date;
    private double _minutes;
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
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
    public virtual string GetName()
    {
        return "Activity";
    }
    public string GetSummary()
    {
        return $"{_date} {GetName()} ({_minutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}