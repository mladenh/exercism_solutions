using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();

    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> dict = GetEmptyDictionary();
        dict.Add
       (1, "United States of America");
        dict.Add(55, "Brazil");
        dict.Add(91, "India");

        return dict;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> dict = GetEmptyDictionary();
        dict.Add(countryCode, countryName);
        return dict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        Dictionary<int, string> dict = GetExistingDictionary();
        dict.Add(countryCode, countryName);
        return dict;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!existingDictionary.ContainsKey(countryCode))
        {
            return "";
        }
        String country = existingDictionary[countryCode];
        return country;

    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (!existingDictionary.ContainsKey(countryCode))
        {
            return false;
        }
        return true;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (!existingDictionary.ContainsKey(countryCode))
        {
            return existingDictionary;
        }
        existingDictionary[countryCode] = countryName;
        return existingDictionary;

    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int length = 0;
        string longestCountryName = "";

        foreach (var item in existingDictionary)
        {
            if (item.Value.Length > length)
            {
                length = item.Value.Length;
                longestCountryName = item.Value;
            }

        }

        return longestCountryName;

    }
}