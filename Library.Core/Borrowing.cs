namespace Library.Core;

using System;

public class Borrowing
{
    public Item BorrowedItem { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsReturned { get; set; }
    public bool IsRenewed { get; set; }
}
