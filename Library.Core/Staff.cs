namespace Library.Core;

public sealed class Staff : Member
{
    public override void BorrowItem(Item item)
    {
        if (item.Borrowed is not null)
        {
            return;
        }

        base.BorrowItem(item);
    }
}
