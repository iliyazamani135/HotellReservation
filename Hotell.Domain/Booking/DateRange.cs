public class DateRange
{
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }

    public DateRange(DateTime start, DateTime end)
    {
        if (end < start) throw new ArgumentException("End date must be after start date");
        StartDate = start;
        EndDate = end;
    }

    public bool Overlaps(DateRange other)
        => StartDate < other.EndDate && EndDate > other.StartDate;
}
