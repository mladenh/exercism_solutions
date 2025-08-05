public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string output = "";
        foreach (char c in nucleotide)
        {
            if (c == 'C')
                output += 'G';
            else if (c == 'G')
                output += 'C';
            else if (c == 'T')
                output += 'A';
            else if (c == 'A')
                output += 'U';
        }
        return output;
    }
}