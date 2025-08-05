using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string umdr = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            umdr = umdr + input[i];
        }
        return umdr;
        //throw new NotImplementedException("You need to implement this function.");
    }
}