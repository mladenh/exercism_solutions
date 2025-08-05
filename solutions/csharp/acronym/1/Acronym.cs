using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string input = phrase.ToUpper();
        string output = "";

        output += input[0];

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ' || input[i] == '-' || input[i] == '_')

                if (char.IsLetterOrDigit(input[i + 1]) == true)
                    output += input[i + 1];
        }

        return output;
    }
}