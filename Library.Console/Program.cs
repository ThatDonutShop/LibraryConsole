﻿using Library.Core;
using Spectre.Console;
using System;

AnsiConsole.MarkupLine("[teal]Weltec Library[/]");

var library = new WeltecLibrary();
var clock = new SystemClock();

// items borrowed by student noah
var noah = new Student { FirstName = "Noah", LastName = "Rogers", Password = "password", Email = "noah@gmail.com" };
library.Add(noah);

var monster = new Book("The Monster");
library.Add(monster);

var tree = new Book("The tree");
library.Add(tree);

var howTo = new Article("How To");
library.Add(howTo);

var breakingNews = new Article("Breaking News");
library.Add(breakingNews);

var guide = new DigitalMedia("Guide to Eating");
library.Add(guide);

noah.BorrowItem(monster, clock);
noah.BorrowItem(tree, clock);
noah.BorrowItem(howTo, clock);
noah.BorrowItem(breakingNews, clock);
noah.BorrowItem(guide, clock);

// items borrowed by staff member jim
var jim = new Staff { FirstName = "Jim", LastName = "Smith", Password = "password", Email = "jim.smith@gmail.com" };
library.Add(jim);

var egg = new Book("The egg");
library.Add(egg);

var recipe = new Article("Recipes");
library.Add(recipe);

jim.BorrowItem(egg, clock);
jim.BorrowItem(recipe, clock);

// items unborrowed
var journey = new Book("The Journey Within");
library.Add(journey);

var mystery = new Book("The Mystery of Midnight Manor");
library.Add(mystery);

var healthTips = new Article("10 Health Tips for a Better You");
library.Add(healthTips);

var spaceDiscovery = new Article("Space Exploration: The Next Frontier");
library.Add(spaceDiscovery);

var fitnessVideo = new DigitalMedia("Fitness at Home: A Beginner's Guide");
library.Add(fitnessVideo);

var cookingTutorial = new DigitalMedia("Cooking Mastery: From Novice to Chef");
library.Add(cookingTutorial);

do
{
    Console.WriteLine(string.Empty);

    var command = AnsiConsole.Prompt(new SelectionPrompt<Commands>()
        .Title(" [teal]What do you want to do[/]?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
        .AddChoices((Commands[])Enum.GetValues(typeof(Commands)))
        .UseConverter((commandName) =>
         {
             switch (commandName)
             {
                 case Commands.CreateStaffMember:
                     return "Create staff member";
                 case Commands.CreateStudent:
                     return "Register student";
                 case Commands.AddLibraryItem:
                     return "Add item to library catalog";
                 case Commands.RemoveLibraryItem:
                     return "Remove item from library catalog";
                 case Commands.ListCatalogItems:
                     return "List items in the catalog";
                 case Commands.BorrowItem:
                     return "Issue library item";
                 case Commands.DisplayBorrowedBooks:
                     return "Display members borrowed items";
                 case Commands.RenewLibraryItem:
                     return "Renew a library item";
                 case Commands.ReturnLibraryItem:
                     return "Return a library book";
                 default:
                     throw new NotImplementedException(commandName.ToString());
             }
         }));

    switch (command)
    {
        case Commands.CreateStaffMember:
            CreateStaffMember();
            break;
        case Commands.CreateStudent:
            CreateStudent();
            break;
        case Commands.AddLibraryItem:
            AddLibraryItem();
            break;
        case Commands.RemoveLibraryItem:
            RemoveLibraryItem();
            break;
        case Commands.ListCatalogItems:
            ListCatalogItems();
            break;
        case Commands.BorrowItem:
            BorrowItem();
            break;
        case Commands.DisplayBorrowedBooks:
            DisplayBorrowedBooks();
            break;
        case Commands.RenewLibraryItem:
            RenewLibraryItem();
            break;
        case Commands.ReturnLibraryItem:
            ReturnLibraryItem();
            break;
        default:
            throw new NotSupportedException(command.ToString());
    }

} while (true);

void CreateStaffMember()
{
    AnsiConsole.MarkupLine("[teal]Add staff member[/]");

    var firstName = AnsiConsole.Ask<string>("[teal]First name:[/]");
    var lastName = AnsiConsole.Ask<string>("[teal]Last name:[/]");
    var password = AnsiConsole.Ask<string>("[teal]Password:[/]"); 
    var email = AnsiConsole.Ask<string>("[teal]Email:[/]");



    var staff = new Staff()
    {
        FirstName = firstName,
        LastName = lastName,
        Password = password,
        Email = email
    };

    library.Members.Add(staff);

    AnsiConsole.MarkupLine("[teal]Added[/] {0}", staff);
}

void CreateStudent()
{
    AnsiConsole.MarkupLine("[teal]Add student[/]");

    var firstName = AnsiConsole.Ask<string>("[teal]First name:[/]");
    var lastName = AnsiConsole.Ask<string>("[teal]Last name:[/]");
    var password = AnsiConsole.Ask<string>("[teal]Password:[/]");
    var email = AnsiConsole.Ask<string>("[teal]Email:[/]");


    var student = new Student()
    {
        FirstName = firstName,
        LastName = lastName,
        Password = password,
        Email = email
    };

    library.Members.Add(student);

    AnsiConsole.MarkupLine("[teal]Added[/] {0}", student);
}

void AddLibraryItem()
{
    var resourceType = AnsiConsole.Prompt(new SelectionPrompt<ResourceTypes>()
      .Title("[teal]Add library item[/]")
      .UseConverter((resourceType) =>
      {
          switch (resourceType)
          {
              case ResourceTypes.DigtalContent:
                  return "Digital media";
              case ResourceTypes.Book:
              case ResourceTypes.Article:
              default:
                  return resourceType.ToString();

          }
      })
      .AddChoices(new[]
      {
          ResourceTypes.Book,
          ResourceTypes.Article,
          ResourceTypes.DigtalContent      ,
      }));

    var title = AnsiConsole.Ask<string>("[teal]The Title:[/]");

    Item item;

    switch (resourceType)
    {
        case ResourceTypes.Book:
            item = new Book(title);
            break;
        case ResourceTypes.Article:
            item = new Article(title);
            break;
        case ResourceTypes.DigtalContent:
            item = new DigitalMedia(title);
            break;
        default:
            throw new NotImplementedException(resourceType.ToString());
    }

    library.Add(item);
}

void RemoveLibraryItem()
{
    var catalog = library.GetCatalogItems().OrderBy(c => c.Title);

    var item = AnsiConsole.Prompt(new SelectionPrompt<Item>()
        .Title("[teal]Remove library item[/]")
        .AddChoices(catalog));

    library.Remove(catalog.First(c => c.Title == item.Title));

    AnsiConsole.MarkupLine("[teal]Removed the item '{0}'[/]", item.Title);
}

void ListCatalogItems()
{
    var table = new Table();

    table.Expand();
    table.LeftAligned();
    table.Border(TableBorder.Rounded);
    table.AddColumn(new TableColumn("Title").Centered());
    table.AddColumn(new TableColumn("Type").Centered());

    foreach (var item in library
        .GetCatalogItems()
        .OrderBy(c => c.GetType().Name)
        .ThenBy(c => c.Title))
    {
        table.AddRow(item.Title, item.GetType().Name).LeftAligned();
    }

    AnsiConsole.Write(table);
}

void BorrowItem()
{
    var members = library.Members.OrderBy(m => m.FirstName).ToList();

    var catalogItems = library
        .GetCatalogItems()
        .Where(c => c.Borrowed is null)
        .OrderBy(c => c.Title)
        .ToList();

    if (members.Any() && catalogItems.Any())
    {
        AnsiConsole.MarkupLine("[teal]Who is borrowing the item?[/]");
        var member = AnsiConsole.Prompt(new SelectionPrompt<Member>().AddChoices(members));

        AnsiConsole.MarkupLine("[teal]What resource would you like to borrow?[/]");
        var catalogItem = AnsiConsole.Prompt(new SelectionPrompt<Item>().AddChoices(catalogItems));

        if (member.BorrowItem(catalogItem, clock))
        {
            AnsiConsole.MarkupLine("[teal]'{0}' has borrowed'{1}'[/]", member, catalogItem);
        }
        else
        {
            AnsiConsole.MarkupLine("[teal]'{0}' cannot be borrowed[/]", catalogItem);
        }
    }
}

void DisplayBorrowedBooks()
{
    var members = library.Members.OrderBy(m => m.FirstName).ToList();
    if (members.Any())
    {
        AnsiConsole.MarkupLine("[teal]Whos borrowings would you like to display?[/]");
        var member = AnsiConsole.Prompt(new SelectionPrompt<Member>().AddChoices(members));

        var borrowedItemsTable = new Table();

        borrowedItemsTable.Expand();
        borrowedItemsTable.LeftAligned();
        borrowedItemsTable.Border(TableBorder.Rounded);
        borrowedItemsTable.AddColumns(
            new TableColumn("Title").Centered(),
            new TableColumn("Borrowed Date").Centered(),
            new TableColumn("Due Date").Centered(),
            new TableColumn("Number of times renewed").Centered(),
            new TableColumn("Overdue Penalty").Centered());

        foreach (var borrowedItem in member.BorrowedItems)
        {
            borrowedItemsTable.AddRow(
                borrowedItem.Item.Title,
                borrowedItem.BorrowDate.ToLongDateString(),
                borrowedItem.DueDate.ToLongDateString(),
                borrowedItem.RenewedTimes.ToString(),
                borrowedItem.OverDuePenalty.ToString("C"));

        }

        AnsiConsole.Write(borrowedItemsTable);

    }
}

void RenewLibraryItem()
{
    var members = library.Members.OrderBy(m => m.FirstName).ToList();
    if (members.Any())
    {
        AnsiConsole.MarkupLine("[teal]Who would you like to renew an item for?[/]");
        var member = AnsiConsole.Prompt(new SelectionPrompt<Member>().AddChoices(members));

        AnsiConsole.MarkupLine("[teal]What would you like to renew?[/]");
        var borrowedItems = member.BorrowedItems.ToList();
        var catalog = AnsiConsole.Prompt(new SelectionPrompt<BorrowedItem>().AddChoices(borrowedItems));

        if (member.RenewItem(catalog.Item, clock))
        {
            AnsiConsole.MarkupLine("[teal]'{0}' has renewed {1} time(s) '{2}'[/]", member, catalog.RenewedTimes, catalog);
        }
        else
        {
            AnsiConsole.MarkupLine("[teal]'{0}' cannot be renewed[/]", catalog);
        }
    }
}

void ReturnLibraryItem()
{
    var members = library.Members.OrderBy(m => m.FirstName).ToList();
    if (members.Any())
    {
        AnsiConsole.MarkupLine("[teal]Who would you like to return an item for?[/]");
        var member = AnsiConsole.Prompt(new SelectionPrompt<Member>().AddChoices(members));

        AnsiConsole.MarkupLine("[teal]What would you like to return?[/]");
        var borrowedItem = AnsiConsole.Prompt(new SelectionPrompt<BorrowedItem>().AddChoices(member.BorrowedItems));

        if (member.ReturnItem(borrowedItem.Item))
        {
            AnsiConsole.MarkupLine("[teal]'{0}' has returned '{1}'[/]", member, borrowedItem.Item.Title);
        }
        else
        {
            AnsiConsole.MarkupLine("[teal]'{0}' cannot be returned[/]", borrowedItem.Item.Title);
        }
    }
}

enum Commands
{
    CreateStaffMember,
    CreateStudent,
    AddLibraryItem,
    RemoveLibraryItem,
    ListCatalogItems,
    BorrowItem,
    DisplayBorrowedBooks,
    RenewLibraryItem,
    ReturnLibraryItem
}

enum ResourceTypes
{
    Book,
    Article,
    DigtalContent
}

