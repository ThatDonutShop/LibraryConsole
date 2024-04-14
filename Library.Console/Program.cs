using Library.Core;
using Spectre.Console;
using System;

AnsiConsole.MarkupLine("[teal]Weltec Library[/]");

var library = new WeltecLibrary();
var clock = new SystemClock();

var noah = new Student { FirstName = "Noah", LastName = "Rogers" };
library.Add(noah);

var monster = new Book("The Monster");
library.Add(monster);
library.Add(new Book("Hanging Tree"));
library.Add(new Article("How to grow trees"));

noah.BorrowItem(monster, clock);

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
                     return "Display Members Borrowed items";
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
        default:
            throw new NotSupportedException(command.ToString());
    }

} while (true);

void CreateStaffMember()
{
    AnsiConsole.MarkupLine("[teal]Add staff member[/]");

    var firstName = AnsiConsole.Ask<string>("[teal]First name:[/]");
    var lastName = AnsiConsole.Ask<string>("[teal]Last name:[/]");

    var staff = new Staff()
    {
        FirstName = firstName,
        LastName = lastName
    };

    library.Members.Add(staff);

    AnsiConsole.MarkupLine("[teal]Added[/] {0}", staff);
}

void CreateStudent()
{
    AnsiConsole.MarkupLine("[teal]Add student[/]");

    var firstName = AnsiConsole.Ask<string>("[teal]First name:[/]");
    var lastName = AnsiConsole.Ask<string>("[teal]Last name:[/]");

    var student = new Student()
    {
        FirstName = firstName,
        LastName = lastName
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
    var catalogItems = library.GetCatalogItems().OrderBy(c => c.Title).ToList();
    if (members.Any() && catalogItems.Any())
    {
        AnsiConsole.MarkupLine("[teal]Who is borrowing the item?[/]");
        var member = AnsiConsole.Prompt(new SelectionPrompt<Member>().AddChoices(members));

        AnsiConsole.MarkupLine("[teal]What resource would you like to borrow?[/]");
        var catalog = AnsiConsole.Prompt(new SelectionPrompt<Item>().AddChoices(catalogItems));

        AnsiConsole.MarkupLine("[teal]'{0}' has borrowed '{1}'[/]", member, catalog);
        member.BorrowItem(catalog, clock);
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
                borrowedItem.IsRenewed.ToString(),
                borrowedItem.OverDuePenalty.ToString("C"));

        }

        AnsiConsole.Write(borrowedItemsTable);

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
    DisplayBorrowedBooks
}

enum ResourceTypes 
{ 
    Book,
    Article,
    DigtalContent
}

