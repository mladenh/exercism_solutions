using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        //throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
        
        string subs = logLine.Split(':')[1];
        string TrimString = subs.Trim();
        return TrimString;
        

    }

    public static string LogLevel(string logLine)
    {
        // throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");

        string lower = logLine.ToLower();
        string sub  = lower.Split('[')[1].Split(']')[0];
        return sub;


    }

    public static string Reformat(string logLine)
    {
        string ret = Message(logLine) + ' ' + '(' + LogLevel(logLine) + ')';
        return ret;
        //throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
