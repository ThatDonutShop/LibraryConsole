
namespace Library.Core;

public class BorrowedItem
{
    private readonly IClock _clock;
    private readonly decimal _overDuePerDay;

    public BorrowedItem(IClock clock, decimal overDuePerDay)
    {
        _clock = clock;
        _overDuePerDay = overDuePerDay;
    }

    public required Item Item { get; set; }
    
    public DateOnly BorrowDate { get; set; }

    public DateOnly DueDate { get; set; }

    public bool IsReturned { get; set; }

    public bool IsRenewed => RenewedTimes > 0;

    public int RenewedTimes { get; set; }

    public int DaysOverDue
    {
        get
        {
            var days = _clock.GetNowAsDate().DayNumber - DueDate.DayNumber;
            if (days < 0)
            {
                return 0;
            }
            return days;
        }
    }

    public bool IsOverdue => DaysOverDue > 0;

    public decimal OverDuePenalty => _overDuePerDay * DaysOverDue;

    public override string ToString()
    {
        return Item.Title;
    }

}
