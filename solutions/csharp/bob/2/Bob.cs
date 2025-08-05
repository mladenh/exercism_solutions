using System;

public static class Bob
{
    public static string Response(string statement)
    {
        string trimString = statement.Trim();

        if (trimString =="")
        {
            return "Fine. Be that way!";
        }

        if ((trimString.EndsWith('?')) && (trimString.ToUpper() == trimString && trimString.ToLower() != trimString))
        {
            return "Calm down, I know what I'm doing!";
        }
        if (trimString.EndsWith('?'))
        {
            return "Sure.";
        }
        if (trimString.ToUpper() == trimString && trimString.ToLower() != trimString)
        {
            return "Whoa, chill out!";
        }


        else return "Whatever.";

    }
}