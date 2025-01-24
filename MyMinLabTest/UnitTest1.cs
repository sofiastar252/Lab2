using MyMinLib;
using Xunit;

public class MinFinderTests
{
    [Fact]
    public void Test_Min_TwoNumbers()
    {
        Assert.Equal(3, Class1.Min(5, 3));
        Assert.Equal(2.4, Class1.Min(7.8, 2.4));
    }

    [Fact]
    public void Test_Min_ThreeNumbers()
    {
        Assert.Equal(3, Class1.Min(5, 3, 8));
        Assert.Equal(2.4, Class1.Min(7.8, 2.4, 10.1));
    }
}
