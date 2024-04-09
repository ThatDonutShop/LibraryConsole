namespace Library.Core;

using System.Collections.Generic;

public abstract class Member
{
    private List<Borrowing> _borrowings = new();

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Borrowing[] Borrowings => _borrowings.ToArray();    

    public virtual void Add(Item item)
    {
        if (item.IsBorrowed)
        {
            return;
        }
        item.IsBorrowed = true;
        _borrowings.Add(new Borrowing()
        {
            BorrowDate = DateTime.Now,
            BorrowedItem = item,
            DueDate = DateTime.Now.AddDays(5),
            IsRenewed = false,
        });
    }
}
