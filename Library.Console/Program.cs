using Library.Core;

var library = new WeltecLibrary();

var book = new Book("The Tree");

//library.AddItemToCatalog(book);

library.Remove(book);

Console.WriteLine(library.Catalog.Count());
