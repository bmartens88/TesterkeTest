namespace Calculator.UnitTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 3, 6)]
    public void WhenGivenTwoIntegers_Add_ShouldReturnSum(int a, int b, int expected)
    {
        var result = Calculator.Add(a, b);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(3, 3, 0)]
    public void WhenGivenTwoIntegers_Subtract_ShouldReturnDifference(int a, int b, int expected)
    {
        var result = Calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(3, 3, 9)]
    public void WhenGivenTwoIntegers_Multiply_ShouldReturnProduct(int a, int b, int expected)
    {
        var result = Calculator.Multiply(a, b);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(1, 2, 0.5)]
    [InlineData(3, 3, 1)]
    public void WhenGivenTwoIntegers_Divide_ShouldReturnQuotient(int a, int b, int expected)
    {
        var result = Calculator.Divide(a, b);
        Assert.Equal(result, expected);
    }
}
