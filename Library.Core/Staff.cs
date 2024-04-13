namespace Library.Core;

public sealed class Staff : Member
{
    public override bool BorrowItem(Item item, IClock clock)
    {
        if (item.Borrowed is not null)
        {
            return false;
        }

       return base.BorrowItem(item, clock);
    }

    protected override DateOnly GetDueDate(DateOnly borrowedDate) => new(borrowedDate.Year, 12, 31);
}
