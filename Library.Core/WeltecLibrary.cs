namespace Library.Core;

using System;
using System.Collections.Generic;

public class WeltecLibrary
{
    private readonly List<Item> _items = new();
    private readonly List<Member> _members = new();

    public List<Member> Members => _members;

    //public Borrowing[] GetBorrowedItems(Member member)
    //{
    //    return member.Borrowings.ToArray();
    //}

    public void BorrowItem(Member member, Item item) 
    {
        if (_items.Contains(item) == false) return;

        item.IsBorrowed = true;
        member.Borrowings.Add(new Borrowing()
        {
            BorrowDate = DateTime.Now,
            BorrowedItem = item,
            DueDate = DateTime.Now.AddDays(5),
            IsRenewed = false,
        });
    }

    public void RenewBorrowedItem(Member member, Item item) 
    {

    }

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public void Remove(Item item)
    {
        if (_items.Contains(item))
        {
            _items.Remove(item);
        }
    }

    public Item[] GetCatalogItems()
    {
        return _items.ToArray();
    }

    public T[] GetCatalogItems<T>() where T : Item
    {
        var items = new List<T>();

        foreach (var item in _items)
        {
            if (item is T)
            {
                items.Add((T)item);
            }
        }

        return items.ToArray();
    }
}