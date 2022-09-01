using vocabulary;

namespace chapter02Test;


public class CalculatorUnitTests
{
    [Fact]
    public void TestingAdding2And2()
    {
        double a=2;
        double b=2;
        double expected= 4;
        Chapter04 calc = new();

        // act
        double actual = calc.Add(a,b);

        Assert.Equal(expected,actual);
    }

    [Fact]
    public void TestingAdding2And3()
 {
        double a=2;
        double b=3;
        double expected= 5;
        Chapter04 calc = new();

        // act
        double actual = calc.Add(a,b);

        Assert.Equal(expected,actual);
    }
}