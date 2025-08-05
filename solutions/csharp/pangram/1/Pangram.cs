using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        //throw new NotImplementedException();
        char[] alphabet =  { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        foreach (char letter in alphabet)
        {
            if (!input.ToLower().Contains(letter)) return false;

        }
        return true;
    }
}
