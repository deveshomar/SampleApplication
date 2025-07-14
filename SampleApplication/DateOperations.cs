using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    public class DateTimeOperations
    {
        // Get current date and time
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        // Add days to a given date
        public DateTime AddDaysToDate(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        // Add hours to a given date
        public DateTime AddHoursToDate(DateTime date, double hours)
        {
            return date.AddHours(hours);
        }

        // Add minutes to a given date
        public DateTime AddMinutesToDate(DateTime date, double minutes)
        {
            return date.AddMinutes(minutes);
        }

        // Subtract two dates and return TimeSpan
        public TimeSpan GetDifference(DateTime start, DateTime end)
        {
            return end - start;
        }

        // Compare two dates: returns -1 if date1 < date2, 1 if date1 > date2, 0 if equal
        public int CompareDates(DateTime date1, DateTime date2)
        {
            return DateTime.Compare(date1, date2);
        }

        // Format DateTime to string with custom format
        public string FormatDateTime(DateTime date, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return date.ToString(format);
        }

        // Parse string to DateTime, returns true if successful
        public bool TryParseDateTime(string dateString, out DateTime parsedDate)
        {
            return DateTime.TryParse(dateString, out parsedDate);
        }

        // Get individual components from DateTime
        public (int year, int month, int day, int hour, int minute, int second) GetDateComponents(DateTime date)
        {
            return (date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
        }

        // Add months to a given date
        public DateTime AddMonthsToDate(DateTime date, int months)
        {
            return date.AddMonths(months);
        }

        // Add years to a given date
        public DateTime AddYearsToDate(DateTime date, int years)
        {
            return date.AddYears(years);
        }
    }
}

/*
 *  DateTimeOperations dtOps = new DateTimeOperations();

        DateTime now = dtOps.GetCurrentDateTime();
        Console.WriteLine("Now: " + now);

        DateTime tomorrow = dtOps.AddDaysToDate(now, 1);
        Console.WriteLine("Tomorrow: " + tomorrow);

        TimeSpan diff = dtOps.GetDifference(new DateTime(2023, 1, 1), now);
        Console.WriteLine($"Days since 2023-01-01: {diff.TotalDays}");

        int cmp = dtOps.CompareDates(new DateTime(2024, 5, 1), new DateTime(2024, 5, 10));
        Console.WriteLine($"Compare result: {cmp}");  // -1 means first date is earlier

        string formatted = dtOps.FormatDateTime(now, "MMM dd, yyyy HH:mm");
        Console.WriteLine("Formatted date: " + formatted);

        if (dtOps.TryParseDateTime("2025-07-14 15:30", out DateTime parsed))
        {
            Console.WriteLine("Parsed date: " + parsed);
        }

        var components = dtOps.GetDateComponents(now);
        Console.WriteLine($"Year: {components.year}, Month: {components.month}, Day: {components.day}");

        DateTime nextMonth = dtOps.AddMonthsToDate(now, 1);
        Console.WriteLine("Next month: " + nextMonth);

        DateTime nextYear = dtOps.AddYearsToDate(now, 1);
        Console.WriteLine("Next year: " + nextYear);
 * 
 */
