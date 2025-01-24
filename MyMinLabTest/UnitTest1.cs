using MyMinLib; 
using Xunit;

public class MinFinderTests
{
    [Fact]
    public void Test_Min_TwoNumbers()
    {
        double result1 = Class1.Min(5, 3);
        double result2 = Class1.Min(7.8, 2.4);

        Console.WriteLine($"The minimum of 5 and 3 is {result1}");
        Console.WriteLine($"The minimum of 7.8 and 2.4 is {result2}");

        Assert.Equal(3, result1);
        Assert.Equal(2.4, result2);
    }

    [Fact]
    public void Test_Min_ThreeNumbers()
    {
        double result1 = Class1.Min(5, 3, 8);
        double result2 = Class1.Min(7.8, 2.4, 10.1);

        Console.WriteLine($"The minimum of 5, 3, and 8 is {result1}");
        Console.WriteLine($"The minimum of 7.8, 2.4, and 10.1 is {result2}");

        Assert.Equal(3, result1);
        Assert.Equal(2.4, result2);
    }
}
