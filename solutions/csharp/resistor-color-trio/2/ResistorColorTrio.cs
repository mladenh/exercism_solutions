public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        string firstv = colors[0];
        string secondv = colors[1];
        string thirdv = colors[2];
        testforcolor(firstv);
        testforcolor(secondv);
        endofstring(thirdv);

        var output = int.Parse(testforcolor(firstv) + testforcolor(secondv) + endofstring(thirdv));

        return output < 1000
            ? output + " ohms"
            : output < 10000000 ? (output / 1000) + " kiloohms" : output < 1000000000 ? (output / 1000000) + " megaohms" : "";
    }

    private static string endofstring(string thirdv)
    {
        var value = thirdv switch
        {
            "black" => "",
            "brown" => "0",
            "red" => "00",
            "orange" => "000",
            "yellow" => "0000",
            "green" => "00000",
            "blue" => "000000",
            "violet" => "0000000",
            "grey" => "00000000",
            "white" => "000000000",
            _ => "-1",
        };
        return value;
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
