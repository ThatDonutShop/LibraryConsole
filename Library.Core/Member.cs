namespace Library.Core;

using System.Collections.Generic;

public abstract class Member
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public List<Borrowing> Borrowings { get; set; } = new();    
}
