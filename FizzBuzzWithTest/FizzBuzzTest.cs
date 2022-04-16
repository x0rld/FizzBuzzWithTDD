using Xunit;

namespace FizzBuzzWithTest;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(1)]
    public void one_should_be_one(int value)
    {
        Assert.True(FizzBuzz.ToFizzBuzz(value) == "1");
    }

}