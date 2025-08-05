using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null && department == null)
        {
            return _ = $"{name} - OWNER";
        }
        else if (id == null)
        {
            return _ = $"{name} - {department.ToUpper()}";
        }

        if (department == null)
        {
            return _ = $"[{id}] - {name} - OWNER";
        }
        return _ = $"[{id}] - {name} - {department.ToUpper()}";
    }
}
