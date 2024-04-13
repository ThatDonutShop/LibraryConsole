
namespace Library.Core;

public class Borrowing
{
    private readonly IClock _clock;
    private readonly decimal _overDuePerDay;

    public Borrowing(IClock clock, decimal overDuePerDay)
    {
        _clock = clock;
        _overDuePerDay = overDuePerDay;
    }

    public required Item BorrowedItem { get; set; }
    
    public DateOnly BorrowDate { get; set; }

    public DateOnly DueDate { get; set; }

    public bool IsReturned { get; set; }

    public bool IsRenewed { get; set; }

    public int DaysOverDue => _clock.GetNowAsDate().DayNumber - DueDate.DayNumber;

    public bool IsOverdue => DaysOverDue > 0;

    public decimal OverDuePenalty => _overDuePerDay * DaysOverDue;
    
}
