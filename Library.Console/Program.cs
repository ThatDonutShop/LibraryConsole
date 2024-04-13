using Library.Core;
using Spectre.Console;

AnsiConsole.MarkupLine("[teal]Weltec Library[/]");

var library = new WeltecLibrary();


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

    AnsiConsole.Markup("[teal]Added {0}[/]", staff);
}

do
{
    Console.WriteLine(string.Empty);

    var command = AnsiConsole.Prompt(
    new SelectionPrompt<Commands>()
        .Title("What do you want to [teal]do[/]?")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
        .AddChoices(new[] {
            Commands.CreateStaffMember,
            Commands.CreateStudent }));

    switch (command)
    {
        case Commands.CreateStaffMember:
            CreateStaffMember();
            break;
        default:
            throw new NotSupportedException(command.ToString());
    }

} while (true);

enum Commands
{
    CreateStaffMember,
    CreateStudent
}

