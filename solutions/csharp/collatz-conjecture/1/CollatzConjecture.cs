using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int input = number;
        int steps = 0;
        if (input < 1)
        {
            ArgumentOutOfRangeException exception = new ArgumentOutOfRangeException();
            throw exception;
        }

        do
        {
            if(input == 1)
            { return 0; }
            if (input % 2 == 0)
            { input = input / 2; }

            else
            {
                input = (input * 3) + 1;
            }
            steps++;
        } while (input != 1);
        return steps;

        // throw new NotImplementedException("You need to implement this function");
    }
}