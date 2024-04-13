using Library.Core;
using Spectre.Console;
using System;

AnsiConsole.MarkupLine("[teal]Weltec Library[/]");

var library = new WeltecLibrary();

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
    
    var title = AnsiConsole.Prompt(new SelectionPrompt<string>()
        .Title("[teal]Remove library item[/]")
        .AddChoices(catalog.Select(c => c.Title)));

    library.Remove(catalog.First(c => c.Title == title));

    AnsiConsole.MarkupLine("[teal]Removed the item '{0}'[/]", title);
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

enum Commands
{
    CreateStaffMember,
    CreateStudent,
    AddLibraryItem,
    RemoveLibraryItem,
    ListCatalogItems
}

enum ResourceTypes 
{ 
    Book,
    Article,
    DigtalContent
}

