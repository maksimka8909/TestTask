using TestTask.Interfaces;

namespace TestTask.Classes;

public class Triangle : IShape
{
    public double FirstSide { get; set; }

    public double SecondSide { get; set; }

    public double ThirdSide { get; set; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public bool IsRight()
    {
        double[] sides = { FirstSide, SecondSide, ThirdSide };
        Array.Sort(sides);

        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    public double GetSquare()
    {
        double p = (FirstSide + SecondSide + ThirdSide) / 2;

        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }
}