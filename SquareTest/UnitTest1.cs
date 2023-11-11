namespace SquareTest;

public class UnitTest1
{
    [Fact]
    public void CorrectTriangleSquare()
    {
        Assert.Equal(6, new TestTusk.Classes.Triangle(3, 4, 5).GetSquare());
    }

    [Fact]
    public void IncorrectTriangleSquare()
    {
        Assert.NotEqual(12, new TestTusk.Classes.Triangle(3, 4, 5).GetSquare());
    }
    
    [Fact]
    public void CorrectCircleSquare()
    {
        Assert.Equal(12.57, new TestTusk.Classes.Circle(2).GetSquare());
    }

    [Fact]
    public void IncorrectCircleSquare()
    {
        Assert.NotEqual(12, new TestTusk.Classes.Circle(2).GetSquare());
    }

    [Fact]
    public void TriangleIsRight()
    {
        Assert.True(new TestTusk.Classes.Triangle(3, 4, 5).IsRight());
    }

    [Fact]
    public void TriangleIsNotRight()
    {
        Assert.False(new TestTusk.Classes.Triangle(3, 4, 6).IsRight());
    }
}