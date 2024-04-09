using Library.Core;

var library = new WeltecLibrary();

var book = new Book("The Tree");

library.Remove(book);

Console.WriteLine(library.GetCatalogItems().Count());
