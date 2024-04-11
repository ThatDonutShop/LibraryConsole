namespace Library.Core;

public sealed class Student : Member
{
    public int MaxBorrowings => 5;

    public int MaxRenewals => 1;

    public double PenaltyRate => 5;

    public override void BorrowItem(Item item)
    {
        if (Borrowings.Length >= 5)
        {
            return;
        }

        base.BorrowItem(item);
    }

    protected override DateOnly GetDueDate(DateOnly borrowedDate) => borrowedDate.AddDays(90);
}
