using System;
public static class Bob
{
    private static bool IsEmpty(string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }

    private static bool IsYellQuestion(string input)
    {
        return input.EndsWith('?') && (input.ToUpper() == input && input.ToLower() != input);
    }

    private static bool IsQuestion(string input)
    {
        return input.EndsWith('?');
    }

    private static bool IsYell(string input)
    {
        return input.ToUpper() == input && input.ToLower() != input;
    }

    public static string Response(string statement)
    {


        string trimString = statement.Trim();


        if (IsEmpty(trimString))
        {
            return "Fine. Be that way!";
        }

        if (IsYellQuestion(trimString))
        {
            return "Calm down, I know what I'm doing!";
        }
        if (IsQuestion(trimString))
        {
            return "Sure.";
        }
        if (IsYell(trimString))
        {
            return "Whoa, chill out!";
        }


        return "Whatever.";

    }


}