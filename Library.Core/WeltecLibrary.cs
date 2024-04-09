namespace Library.Core;

using System;
using System.Collections.Generic;

public class WeltecLibrary
{
    private readonly List<Item> _items = new();
    private readonly List<Member> _members = new();

    public Item[] Catalog => _items.ToArray();

   // public List<Member> Members => _members.ToArray();

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