namespace Library.Core;

using System.Collections.Generic;

public abstract class Member
{
    private List<Borrowing> _borrowings = new();

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public Borrowing[] Borrowings => _borrowings.ToArray();    

    public virtual bool BorrowItem(Item item, IClock clock)
    {
        if (item.Borrowed is not null)
        {
            return false;
        }

        var borrowedDate = clock.GetNowAsDate();
        var borrowedItem = new Borrowing(clock, GetPenaltyPerDay())
        {
            BorrowDate = borrowedDate,
            BorrowedItem = item,
            DueDate = GetDueDate(borrowedDate),
            IsRenewed = false,
        };

        item.Borrowed = borrowedItem;

        _borrowings.Add(borrowedItem);

        return true;
    }

    protected abstract DateOnly GetDueDate(DateOnly borrowedDate);

    protected virtual decimal GetPenaltyPerDay() => 5;

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}
