public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        int input = year;
        if (input % 400 == 0 || input % 4 == 0 && input % 100 != 0)
        { return true; }
        // throw new NotImplementedException("You need to implement this function.");
        else return false;

    }

}