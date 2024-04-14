namespace Library.Core;

public sealed class Student : Member
{
    public int MaxBorrowings => 5;

    public int MaxRenewals => 1;

    public double PenaltyRate => 5;

    public override bool RenewItem(Item item, IClock clock)
    {
        if (item.Borrowed?.RenewedTimes >= 1)
        {
            return false;
        }
        return base.RenewItem(item, clock);
    }

    public override bool BorrowItem(Item item, IClock clock)
    {
        if (CanBorrowBook())
        {
            return base.BorrowItem(item, clock);
        }

        return false;
    }

    public bool CanBorrowBook() => BorrowedItems?.Length < 5;

    protected override DateOnly GetDueDate(DateOnly borrowedDate) => borrowedDate.AddDays(90);
}
