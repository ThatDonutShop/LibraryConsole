﻿namespace Library.Core;

using System.Collections.Generic;

public abstract class Member
{
    private List<Borrowing> _borrowings = new();

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public Borrowing[] Borrowings => _borrowings.ToArray();    

    public virtual void BorrowItem(Item item)
    {
        if (item.Borrowed is not null)
        {
            return;
        }

        var borrowedDate = DateOnly.FromDateTime(DateTime.Today);
        var borrowedItem = new Borrowing()
        {
            BorrowDate = borrowedDate,
            BorrowedItem = item,
            DueDate = GetDueDate(borrowedDate),
            IsRenewed = false,
        };

        item.Borrowed = borrowedItem;

        _borrowings.Add(borrowedItem);
    }

    protected abstract DateOnly GetDueDate(DateOnly borrowedDate);
    
}
