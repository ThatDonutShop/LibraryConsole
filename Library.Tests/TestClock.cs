using Library.Core;

namespace Library.Tests;

public class TestClock : IClock
{
    private readonly DateTime _dateTime;

    public TestClock(DateTime dateTime)
    {
        _dateTime = dateTime;
    }

    public DateTime Now => _dateTime;
}
