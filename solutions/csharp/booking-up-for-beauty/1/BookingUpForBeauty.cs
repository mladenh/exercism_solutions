using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var parsedDate = DateTime.Parse(appointmentDateDescription);
        return parsedDate;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var now = DateTime.Now;

        if (appointmentDate < now)
        {
            return true;
        }
        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        string ParseData = "You have an appointment on " + appointmentDate.ToString() + ".";
        return ParseData;
    }

    public static DateTime AnniversaryDate()
    {
        var date1 = new DateTime(2022, 9, 15, 0, 0, 0);
        return date1;
    }
}
