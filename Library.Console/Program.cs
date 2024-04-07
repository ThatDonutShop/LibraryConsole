using Library.Core;

var library = new WeltecLibrary();

var book = new Item("The Tree", ItemType.Book);

//library.AddItemToCatalog(book);

library.DeleteItemInCatalog(book);

Console.WriteLine(library.Catalog.Count());

