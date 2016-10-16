using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
        var s = Console.ReadLine();
        DateTime bDay = DateTime.ParseExact(s, "MM.dd.yyyy", CultureInfo.InvariantCulture);
        DateTime today = DateTime.Now;
        DateTime zeroTime = new DateTime(1, 1, 1);
        TimeSpan span = today - bDay;
        int years = (zeroTime + span).Year - 1;
        Console.WriteLine(years);
        Console.WriteLine(years + 10);
    }
}