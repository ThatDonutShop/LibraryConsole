
namespace Library.Core;

public class Borrowing
{
    public Item BorrowedItem { get; set; }
    
    public DateOnly BorrowDate { get; set; }

    public DateOnly DueDate { get; set; }

    public bool IsReturned { get; set; }

    public bool IsRenewed { get; set; }

    public bool IsOverdue(DateOnly now) => DueDate < now;
}
