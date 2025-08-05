using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate = 0;

        if (balance < 0)
        {
            interestRate = 3.213f;
        }
        else if (balance < 1000)
        {
            interestRate = 0.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            interestRate = 1.621f;
        }
        else if (balance >=5000)
        {
            interestRate = 2.475f; 
        }
        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        return _ = balance * (decimal)(InterestRate(balance) / 100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return _ = Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
        do
        {
            balance = AnnualBalanceUpdate(balance);
            year++;

        } while (balance < targetBalance);

        return year;
    }
}
