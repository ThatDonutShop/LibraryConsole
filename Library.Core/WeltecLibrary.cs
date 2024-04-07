namespace Library.Core;

using System;
using System.Collections.Generic;

public class WeltecLibrary
{
    private readonly List<Item> _items = new();
    private readonly List<Member> _members = new();

    public Item[] Catalog => _items.ToArray();

   // public List<Member> Members => _members.ToArray();

    public void AddItemToCatalog(Item item)
    {
        _items.Add(item);
    }

    // Add methods for managing borrowings, returns, renewals, etc.
    // You can implement methods like BorrowItem, ReturnItem, RenewItem, CalculatePenalty, etc.


}