using Xunit;

namespace FizzBuzzWithTest;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    public void OneShouldBeOne(int value)
    {
        Assert.Equal("1", FizzBuzz.ToFizzBuzz(value));
    }
    
    [Theory]
    [InlineData(3)]
    public void IsDivisibleByThree(int value)
    {
        Assert.Equal("fizz",FizzBuzz.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(5)]
    public void IsDivisibleByFive(int value)
    {
        Assert.Equal("buzz", FizzBuzz.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(15)]

    public void IsDivisibleByFiveAndThree(int value)
    {
        Assert.Equal("fizzbuzz",FizzBuzz.ToFizzBuzz(value));
    }
}