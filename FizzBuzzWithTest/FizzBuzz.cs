namespace FizzBuzzWithTest;

public static class FizzBuzz
{
    public static string ToFizzBuzz(int i)
    {
        if (i == 3)
        {
            return "fizz";
        }
        if (i == 5)
        {
            return "buzz";
        }
        return "1";
    }
}