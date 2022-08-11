using Xunit;
using FizzBuzzClass = FizzBuzz.FizzBuzz;
namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void ShouldNotBeFizzBuzz(int value)
    {
        Assert.Equal(value.ToString(), FizzBuzzClass.ToFizzBuzz(value));
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(9)]
    public void IfIsDivisibleByThree(int value)
    {
        Assert.Equal("fizz",FizzBuzzClass.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void IsDivisibleByFive(int value)
    {
        Assert.Equal("buzz", FizzBuzzClass.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void IsDivisibleByFiveAndThree(int value)
    {
        Assert.Equal("fizzbuzz",FizzBuzzClass.ToFizzBuzz(value));
    }
}