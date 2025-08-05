using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime input = moment;
        DateTime output = input.AddSeconds(1000000000);

        return output;
        //throw new NotImplementedException("You need to implement this function.");
    }
}