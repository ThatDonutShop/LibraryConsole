﻿using Library.Core;

namespace Library.Tests;

public class StudentTests
{
    [Fact]
    public void BorrowItem_WhenBookIsBorrowed_SystemIsUpdatedCorrectly()
    {
        var book = new Book("Eggs");

        var student = new Student() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new SystemClock();

        student.BorrowItem(book, clock);
                
        var today = DateOnly.FromDateTime(clock.GetNow());
        
        Assert.NotNull(book.Borrowed);
        Assert.Equal(book.Borrowed, student.Borrowings[0]);
        Assert.Equal(today, student.Borrowings[0].BorrowDate);
        Assert.Equal(today.AddDays(90), student.Borrowings[0].DueDate);
        Assert.False(student.Borrowings[0].IsRenewed);
        Assert.Equal(book, student.Borrowings[0].BorrowedItem);
    }

    [Fact]
    public void Borrowings_AskingForlistOfTheirBorrowings_HasPenaltyOfOneDay()
    {        
        var book = new Book("Eggs and Ham");

        var student = new Student() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(DateTime.Now);

        student.BorrowItem(book, clock);

        clock.TimeTravel(TimeSpan.FromDays(91));

        Assert.True(student.Borrowings[0].IsOverdue); 
        Assert.Equal(1, student.Borrowings[0].DaysOverDue);
        Assert.Equal(5, student.Borrowings[0].OverDuePenalty);
    }

    [Fact]
    public void Borrowings_AskingForlistOfTheirBorrowings_HasCorrectPenalty()
    {
        var book = new Book("Eggs and Ham");

        var student = new Student() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(DateTime.Now);

        student.BorrowItem(book, clock);

        clock.TimeTravel(TimeSpan.FromDays(96));

        Assert.True(student.Borrowings[0].IsOverdue);
        Assert.Equal(6, student.Borrowings[0].DaysOverDue);
        Assert.Equal(30, student.Borrowings[0].OverDuePenalty);
    }

    [Fact]
    public void Borrowings_CannotBorrowMoreThanFiveBooks()
    {
        var book1 = new Book("Eggs and Ham1");
        var book2 = new Book("Eggs and Ham2");
        var book3 = new Book("Eggs and Ham3");
        var book4 = new Book("Eggs and Ham4");
        var book5 = new Book("Eggs and Ham5");
        var book6 = new Book("Eggs and Ham6");

        var student = new Student() { FirstName = "Noah", LastName = "Rogers" };

        var clock = new TestClock(new DateTime(2000, 1, 1));

        student.BorrowItem(book1, clock);
        student.BorrowItem(book2, clock);
        student.BorrowItem(book3, clock);
        student.BorrowItem(book4, clock);
        student.BorrowItem(book5, clock);

        Assert.False(student.BorrowItem(book6, clock));
    }
}
