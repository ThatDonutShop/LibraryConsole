namespace Library.Core;

public sealed class Staff : Member
{
    public override void Add(Item item)
    {
        if (item.IsBorrowed)
        {
            return;
        }

        base.Add(item);
    }
}
