namespace Library.Core
{
    public class SystemClock : IClock
    {
        public DateTime GetNow() => DateTime.Now;
    }
}
