using Library.Core;

Console.WriteLine("Hello");

var library = new WeltecLibrary();

var book = new Item("The Tree", ItemType.Book);

library.AddItemToCatalog(book);

Console.WriteLine(library.Catalog.Count());
