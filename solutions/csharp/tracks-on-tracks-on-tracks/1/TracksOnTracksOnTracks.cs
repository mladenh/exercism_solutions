using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> LanguageList = new()
        {
            "C#",
            "Clojure",
            "Elm"
        };

        return LanguageList;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        int number = languages.Count;
        return number;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.IndexOf("C#") == 0)
        {
            return true;
        }
        else if (languages.IndexOf("C#") == 1 && languages.Count < 4)
        {
            return true;
        }

        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        //compare number of distinct element in list with length of list
       return languages.Distinct().Count() == languages.Count;
    }
}
