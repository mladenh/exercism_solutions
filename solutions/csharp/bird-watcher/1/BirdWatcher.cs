class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = new int[] { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        return _ = birdsPerDay[birdsPerDay.Length - 1];

    }

    public void IncrementTodaysCount()
    {
        int today = birdsPerDay[birdsPerDay.Length - 1];
        birdsPerDay[birdsPerDay.Length - 1] = today + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var day in birdsPerDay)
        {
            if (day == 0)
            {
                return true;
            }

        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }

        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var day in birdsPerDay)
        {
            if (day > 4)
            {
                count++;
            }

        }
        return count;
    }
}
