using Xunit;

namespace FizzBuzzWithTest;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void ShouldNotBeFizzBuzz(int value)
    {
        Assert.Equal(value.ToString(), FizzBuzz.ToFizzBuzz(value));
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(9)]
    public void IfIsDivisibleByThree(int value)
    {
        Assert.Equal("fizz",FizzBuzz.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void IsDivisibleByFive(int value)
    {
        Assert.Equal("buzz", FizzBuzz.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void IsDivisibleByFiveAndThree(int value)
    {
        Assert.Equal("fizzbuzz",FizzBuzz.ToFizzBuzz(value));
    }
}