using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string word1 = word.ToLower().Replace("-", "").Replace(" ", "");
        int count = 0; 
        for (int i = 0; i < word1.Length; i++)
        {
            for (int j = i + 1; j < word1.Length; j++)
            {
                if(word1[i] == word1[j])
                {
                    count++;
                }

            }

        }

        if (count != 0)
            return false;
        else return true;
        //throw new NotImplementedException("You need to implement this function.");
    }
}
