namespace Library.Core;

public sealed class Student : Member
{
    public int MaxBorrowings => 5;

    public int MaxRenewals => 1;

    public double PenaltyRate => 5;

    public override bool BorrowItem(Item item, IClock clock)
    {
        if (Borrowings.Length >= 5)
        {
            return false;
        }

        return base.BorrowItem(item, clock);
    }

    protected override DateOnly GetDueDate(DateOnly borrowedDate) => borrowedDate.AddDays(90);
}
