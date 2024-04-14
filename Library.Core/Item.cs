namespace Library.Core;

public abstract class Item
{
    public Item(string title)
    {
        Title = title;
    }
    
    public string Title { get; }

    public BorrowedItem? Borrowed { get; set;}

    public override string ToString() => Title;
}

