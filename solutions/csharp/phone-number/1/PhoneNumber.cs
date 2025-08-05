using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string newstring = "";
        string sub1 = "0";
        string sub2 = "1";

        foreach (char c in phoneNumber)
        {
            if (char.IsNumber(c))
                newstring += c;
        }
        if (newstring.StartsWith("1"))
            newstring = newstring.Remove(0, 1);

        if ((newstring.IndexOf(sub1) == 0) || (newstring.IndexOf(sub2) == 0) ||  
            (newstring.IndexOf(sub1)==3) || (newstring.IndexOf(sub2) == 3) || 
            (newstring.Length != 10))
        {
            ArgumentException exception = new ArgumentException();
            throw exception;
        }


        return newstring;

    }
}