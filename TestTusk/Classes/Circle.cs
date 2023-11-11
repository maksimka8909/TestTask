using TestTusk.Interfaces;

namespace TestTusk.Classes;

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetSquare()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }
}