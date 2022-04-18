namespace FizzBuzz;

public static class FizzBuzz
{
    public static string ToFizzBuzz(int i)
    {
        if (i % 3 is 0 && i % 5 is 0)
        {
            return "fizzbuzz";
        }
        if (i % 3 == 0)
        {
            return "fizz";
        }
        if (i % 5 == 0)
        {
            return "buzz";
        }
        return i.ToString();
    }
}