

using System.ComponentModel;

class Angle
{
    private double _radians;

    public Angle()
    {
        _radians = 0.0;
    }

    public Angle(double radians)
    {
        _radians = radians;
    }

    public Angle(int degrees)
    {
        _radians = ToRadians(degrees);
    }

    private double ToRadians(double degrees)
    {
        return degrees * Math.PI / 180.0;
    }


    public double GetRadians()
    {
        return _radians;
    }

    public double GetDegrees()
    {
        return ToDegrees();
    }

    private double ToDegrees()
    {
        return _radians / Math.PI * 180.0;
    }

    public void SetDegrees(int degrees)
    {
        _radians = ToRadians(degrees);
    }
}