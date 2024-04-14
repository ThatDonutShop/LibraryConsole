using Library.Core;

namespace Library.Tests;

public class StaffTests
{
    [Fact]
    public void BorrowItem_WhenBookIsBorrowed_SystemIsUpdatedCorrectly()
    {
        var book = new Book("Eggs");

        var staff = new Staff() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(new DateTime(2000, 2, 13));

        staff.BorrowItem(book, clock);

        Assert.NotNull(book.Borrowed);
        Assert.Equal(book.Borrowed, staff.BorrowedItems[0]);
        Assert.Equal(clock.GetNowAsDate(), staff.BorrowedItems[0].BorrowDate);
        Assert.Equal(DateOnly.FromDateTime(new DateTime(2000, 12, 31)), staff.BorrowedItems[0].DueDate);
        Assert.False(staff.BorrowedItems[0].IsRenewed);
        Assert.Equal(book, staff.BorrowedItems[0].Item);
    }

    [Fact]
    public void Borrowings_AskingForlistOfTheirBorrowings_HasPenaltyOfOneDay()
    {
        var book = new Book("Eggs and Ham");

        var staff = new Staff() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(new DateTime(2000, 1, 1));

        staff.BorrowItem(book, clock);

        clock.TimeTravel(TimeSpan.FromDays(366));

        Assert.True(staff.BorrowedItems[0].IsOverdue);
        Assert.Equal(1, staff.BorrowedItems[0].DaysOverDue);
        Assert.Equal(5, staff.BorrowedItems[0].OverDuePenalty);
    }

    [Fact]
    public void Borrowings_AskingForlistOfTheirBorrowings_HasCorrectPenalty()
    {
        var book = new Book("Eggs and Ham");

        var staff = new Staff() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(new DateTime(2000, 1, 1));

        staff.BorrowItem(book, clock);

        clock.TimeTravel(TimeSpan.FromDays(370));

        Assert.True(staff.BorrowedItems[0].IsOverdue);
        Assert.Equal(5, staff.BorrowedItems[0].DaysOverDue);
        Assert.Equal(25, staff.BorrowedItems[0].OverDuePenalty);
    }

    [Fact]
    public void Borrowings_CanBorrowMoreThanFiveBooks()
    {
        var book1 = new Book("Eggs and Ham1");
        var book2 = new Book("Eggs and Ham2");
        var book3 = new Book("Eggs and Ham3");
        var book4 = new Book("Eggs and Ham4");
        var book5 = new Book("Eggs and Ham5");
        var book6 = new Book("Eggs and Ham6");

        var staff = new Staff() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(new DateTime(2000, 1, 1));

        staff.BorrowItem(book1, clock);
        staff.BorrowItem(book2, clock);
        staff.BorrowItem(book3, clock);
        staff.BorrowItem(book4, clock);
        staff.BorrowItem(book5, clock);
      
        Assert.True(staff.BorrowItem(book6, clock));
    }
}
