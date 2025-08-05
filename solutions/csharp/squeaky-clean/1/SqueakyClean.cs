public static class Identifier
{
    

    public static string Clean(string identifier)
    {
        string newString = "";
        bool nextUpper = false; ;

        foreach (char letter in identifier)
        {
            if (letter.Equals(' '))
            {
                newString += '_';
            }

            else if (char.IsControl(letter))
            {
                newString += "CTRL";
            }

            else if (letter >= 'α' && letter <= 'ω')
            {
                continue;
            }

            else if (letter.Equals('-'))
            {
                nextUpper = true;
            }

            else if (nextUpper)
            {
                newString += char.ToUpper(letter);
                nextUpper = false;
            }

            else if (char.IsLetter(letter))
            {
                newString += letter;
            }
        }
        return newString;
    }
}
