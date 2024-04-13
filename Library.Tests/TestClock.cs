using Library.Core;

namespace Library.Tests;

public class TestClock : IClock
{
    private DateTime _dateTime;

    public TestClock(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public void TimeTravel(TimeSpan timeToTravel)
    {
        _dateTime = _dateTime + timeToTravel;
    }

    public DateTime GetNow() => _dateTime;

    public DateOnly GetNowAsDate() => DateOnly.FromDateTime(GetNow());
}
