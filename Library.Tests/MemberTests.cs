using Library.Core;

namespace Library.Tests;

public class MemberTests 
{
    [Fact]
    public void ReturnItem_WhenNotBorrowed_CantReturnBook()
    {
        var book = new Book("the Book");
        var member = new Student() { FirstName = "Noah", LastName = "Rogers" };

        var bookReturned = member.ReturnItem(book);
        
        Assert.False(bookReturned);
    }

    [Fact]
    public void ReturnItem_WhenBorrowedBySomeoneElse_CantReturnBook()
    {
        var book = new Book("the Book");
        var member = new Student() { FirstName = "Noah", LastName = "Rogers" };
        
        member.BorrowItem(book, new SystemClock());

        var member2 = new Student() { FirstName = "Jimmy", LastName = "Bob" };

        var bookReturned = member2.ReturnItem(book);

        Assert.False(bookReturned);
    }

    [Fact]
    public void ReturnItem_Student_CanReturnBook()
    {
        var book = new Book("the Book");
        var member = new Student() { FirstName = "Noah", LastName = "Rogers" };

        var bookBorrowed = member.BorrowItem(book, new SystemClock());

        var bookReturned = member.ReturnItem(book);

        Assert.True(bookBorrowed);
        Assert.True(bookReturned);
        Assert.Null(book.Borrowed);
        Assert.False(member.BorrowedItems.Any());
    }

    [Fact]
    public void ReturnItem_AsStudentWhenBorrowedAndOverdue_CantReturnBook()
    {
        var clock = new TestClock(DateTime.Today);

        var book = new Book("the Book");
        var member = new Student() { FirstName = "Noah", LastName = "Rogers" };

        member.BorrowItem(book, clock);

        clock.TimeTravel(TimeSpan.FromDays(91));

        var bookReturned = member.ReturnItem(book);

        Assert.False(bookReturned);
    }

    [Fact]
    public void ReturnItem_AsStaffWhenBorrowedAndOverdue_CantReturnBook()
    {
        var clock = new TestClock(new DateTime(2000, 1, 1));

        var book = new Book("the Book");
        var member = new Staff() { FirstName = "Noah", LastName = "Rogers" };

        member.BorrowItem(book, clock);

        clock.TimeTravel(TimeSpan.FromDays(366));

        var bookReturned = member.ReturnItem(book);

        Assert.False(bookReturned);
    }
}
