namespace Library.Core;

public sealed class Student : Member
{
    public int MaxBorrowings => 5;

    public int MaxRenewals => 1;

    public double PenaltyRate => 5;

    public override void Add(Item item)
    {
        if (Borrowings.Length >= 5)
        {
            return;
        }

        base.Add(item);
    }
}
