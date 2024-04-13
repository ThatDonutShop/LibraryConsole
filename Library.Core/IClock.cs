
namespace Library.Core
{
    public interface IClock
    {
        DateTime GetNow();

        DateOnly GetNowAsDate() => DateOnly.FromDateTime(GetNow());
    }
}
