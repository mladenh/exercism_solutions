using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] colorarray = Colors();
        return Array.IndexOf(colorarray, color);

    }

    public static string[] Colors()
    {
        string[] colorsarray = new string[] { "black", "brown", "red", "orange", "yellow", 
                                            "green", "blue", "violet", "grey", "white" };
        return colorsarray;
    }
}