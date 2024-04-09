namespace Library.Core;

public abstract class Item
{
    public Item(string title)
    {
        Title = title;
    }
    public bool IsBorrowed { get; set; }
    public string Title { get; }
}

