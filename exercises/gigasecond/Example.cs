using System;

public class Gigasecond
{
    public static DateTime Date(DateTime birthDate)
    {
        return birthDate.AddSeconds(1000000000);
    }
}