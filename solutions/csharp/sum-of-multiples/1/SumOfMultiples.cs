using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        List<int> list = new List<int>();
        foreach (var item in multiples)
        {
            for (int i = 1; i < max; i++)
            {   if (item == 0)
                    continue;
                if (i % item == 0)
                    list.Add(i);
            }

        }
        List<int> noDupes = list.Distinct().ToList();
        sum = noDupes.Sum(x => x);
        return sum;
    }
}