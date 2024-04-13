using Library.Core;
using Spectre.Console;

AnsiConsole.MarkupLine("[teal]Weltec Library[/]");

var library = new WeltecLibrary();

do
{
    Console.WriteLine(string.Empty);

    var command = AnsiConsole.Prompt(new SelectionPrompt<Commands>()
        .Title("What do you want to [teal]do[/]?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
        .AddChoices(new[]
        {
            Commands.CreateStaffMember,
            Commands.CreateStudent,
            Commands.AddLibraryItem
        })
        .UseConverter((commandName) =>
         {
             switch (commandName)
             {
                 case Commands.CreateStaffMember:
                     return "Create staff member";
                 case Commands.CreateStudent:
                     return "Register student";
                 case Commands.AddLibraryItem:
                     return "Add Resource to library catalog";
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
    AnsiConsole.MarkupLine("[teal]Add library item[/]");

    var resourceType = AnsiConsole.Prompt(new SelectionPrompt<ResourceTypes>()
      .Title("What kind of content?")
      .UseConverter((resourceType) => 
      {
          switch (resourceType)
          {
              case ResourceTypes.DigtalContent:
                  return "Digital media";
              case ResourceTypes.Book:
              case ResourceTypes.Article:
                  return resourceType.ToString();
              default:
                  throw new NotImplementedException(resourceType.ToString());

          }
      })
      .AddChoices(new[]
      {
          ResourceTypes.Book,
          ResourceTypes.Article,
          ResourceTypes.DigtalContent       
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

enum Commands
{
    CreateStaffMember,
    CreateStudent,
    AddLibraryItem
}

enum ResourceTypes 
{ 
    Book,
    Article,
    DigtalContent
}

