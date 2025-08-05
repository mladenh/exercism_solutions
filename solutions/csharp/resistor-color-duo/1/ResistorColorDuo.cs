using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string firstv = colors[0];
        string secondv = colors[1];

        testforcolor(firstv);
        testforcolor(secondv);

        var output = testforcolor(firstv) + testforcolor(secondv);
        return int.Parse(output);
    }

    private static string testforcolor(string v)
    {
        var value = v switch
        {
            "black" => "0",
            "brown" => "1",
            "red" => "2",
            "orange" => "3",
            "yellow" => "4",
            "green" => "5",
            "blue" => "6",
            "violet" => "7",
            "grey" => "8",
            "white" => "9",
            _ => "-1",
        };
        return value;
    }
}
