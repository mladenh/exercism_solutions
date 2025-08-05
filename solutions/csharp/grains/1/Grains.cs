using System;

public static class Grains
{
    public static ulong Square(int n)
    {

        int fieldNumber = n;
        if (fieldNumber < 1 || fieldNumber > 64)
        {
            ArgumentOutOfRangeException exception = new ArgumentOutOfRangeException();
            throw exception;
        }


        ulong output = 1;

        for (int i = 1; i < fieldNumber; i++)
        {
            output += output;
        }

        return output;


    }

    public static ulong Total()
    {
        ulong output = 0;
        for (int i = 1; i <= 64; i++)
        {
            output += Square(i);
        }
        return output;
        
    }
}