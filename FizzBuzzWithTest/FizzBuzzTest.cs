using Xunit;

namespace FizzBuzzWithTest;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    public void one_should_be_one(int value)
    {
        Assert.Equal("1", FizzBuzz.ToFizzBuzz(value));
    }
    
    [Theory]
    [InlineData(3)]
    public void three_should_be_fizz(int value)
    {
        Assert.Equal("fizz",FizzBuzz.ToFizzBuzz(value));
    }

    [Theory]
    [InlineData(5)]
    public void five_should_be_buzz(int value)
    {
        Assert.Equal("buzz", FizzBuzz.ToFizzBuzz(value));
    }
}