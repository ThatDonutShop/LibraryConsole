using Library.Core;

namespace Library.Tests;

public class MemberTests
{
    [Fact]
    public void BorrowItem_WhenBookIsBorrowed_SystemIsUpdatedCorrectly()
    {
        var book = new Book("Eggs");

        var student = new Student();

        student.BorrowItem(book);
                
        var today = DateOnly.FromDateTime(DateTime.Today);
        
        Assert.NotNull(book.Borrowed);
        Assert.Equal(book.Borrowed, student.Borrowings[0]);
        Assert.Equal(today, student.Borrowings[0].BorrowDate);
        Assert.Equal(today.AddDays(90), student.Borrowings[0].DueDate);
        Assert.False(student.Borrowings[0].IsRenewed);
        Assert.Equal(book, student.Borrowings[0].BorrowedItem);
    }

    [Fact]
    public void Borrowings_AskingForlistOfTheirBorrowings_CanDisplayPenalties()
    {        
        var book = new Book("Eggs and Ham");

        var student = new Student();

        student.BorrowItem(book);
        
        var future = DateOnly.FromDateTime(DateTime.Now.AddDays(91));
        
        Assert.True(student.Borrowings[0].IsOverdue(future));
        
    }
}
