using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            case < 1:
            case > 11:
                throw new ArgumentOutOfRangeException(shirtNum.ToString(), $"Number {shirtNum} is not in range from 1 to 11");
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case String announcements:
                return announcements;

            case int number:
                if ((int)number < 90)
                {
                string minutes = number.ToString();
                return $"There are {minutes} minutes to go!";
                }
                else
                {
                    return $"There are {number} supporters at the match.";
                }
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";

            case Incident incident:
                return incident.GetDescription();

            case Manager manager:
                if (manager.Club == null)
                {
                    return $"{manager.Name}";
                }
                return $"{ manager.Name} ({manager.Club})";


            default:
                throw new ArgumentException(null, nameof(report));
        }

    }
}
