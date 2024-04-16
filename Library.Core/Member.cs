namespace Library.Core;

using System.Collections.Generic;

public abstract class Member
{
    private List<BorrowedItem> _borrowings = new();

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public BorrowedItem[] BorrowedItems => _borrowings.ToArray();

    public virtual bool RenewItem(Item item, IClock clock)
    {
        if (item.Borrowed is null || item.Borrowed.IsOverdue)
        {
            return false;
        }

        var existingBorrowedItem = _borrowings.Find(b => b.Item == item);
        if (existingBorrowedItem is null)
        {
            return false;
        }

        existingBorrowedItem.RenewedTimes++;
        existingBorrowedItem.BorrowDate = clock.GetNowAsDate();
        existingBorrowedItem.DueDate = GetDueDate(existingBorrowedItem.BorrowDate);

        return true;
    }

    public bool ReturnItem(Item item)
    {
        if (item.Borrowed is null || item.Borrowed.IsOverdue) 
        { 
            return false;
        }

        var existingBorrowedItem = _borrowings.Find(b => b.Item == item);
        if (existingBorrowedItem is null)
        {
            return false;
        }

        item.Borrowed = null;
        _borrowings.Remove(existingBorrowedItem);

        return true;
    }

    public virtual bool BorrowItem(Item item, IClock clock)
    {
        if (item.Borrowed is not null)
        {
            return false;
        }

        var borrowedDate = clock.GetNowAsDate();
        var borrowedItem = new BorrowedItem(clock, GetPenaltyPerDay())
        {
            BorrowDate = borrowedDate,
            Item = item,
            DueDate = GetDueDate(borrowedDate)          
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
