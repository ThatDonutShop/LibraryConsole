namespace Library.Core;

using System.Collections.Generic;

public class Library
{
    public List<Item> Catalog { get; set; }

    public List<Member> Members { get; set; }

    public Library()
    {
        Catalog = new List<Item>();
        Members = new List<Member>();
    }

    // Add methods for managing borrowings, returns, renewals, etc.
    // You can implement methods like BorrowItem, ReturnItem, RenewItem, CalculatePenalty, etc.
}