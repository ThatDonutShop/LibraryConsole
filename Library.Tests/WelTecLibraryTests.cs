using Library.Core;

namespace Library.Tests
{
    public class WelTecLibraryTests
    {
        [Fact]
        public void Add_SingleBook_AddsBookToLibrary()
        {
            var library = new WeltecLibrary();

            library.Add(new Book("The Tree"));

            Assert.Single(library.Catalog);
        }

        [Fact]
        public void Add_ThreeBook_AddsBookToLibrary()
        {
            var library = new WeltecLibrary();

            library.Add(new Book("The Tree0"));
            library.Add(new Book("The Tree1"));
            library.Add(new Book("The Tree2"));

            Assert.Equal(3, library.Catalog.Count());
        }

        [Fact]
        public void Remove_OneBook_RemovesBookFromLibrary()
        {
            var library = new WeltecLibrary();

            library.Add(new Book("The Tree0"));
            library.Add(new Book("The Tree1"));
            library.Add(new Book("The Tree2"));

            library.Remove(new Book("The Tree1"));

            Assert.Equal(2, library.Catalog.Count());
        }

        [Fact]
        public void Remove_BookThatIsNotInCatalog_NoBooksRemoved()
        {
            var library = new WeltecLibrary();

            library.Add(new Book("The Tree0"));
            library.Add(new Book("The Tree1"));
            library.Add(new Book("The Tree2"));

            library.Remove(new Book("The Tree3"));

            Assert.Equal(3, library.Catalog.Count());
        }

        [Fact]
        public void GetCatalogItems_ReturnsBooks() 
        { 
            var library = new WeltecLibrary();

            library.Add(new Book("The Tree0"));
            library.Add(new Article("The Tree1"));
            library.Add(new DigitalMedia("The Tree2"));
            library.Add(new DigitalMedia("The Tree4"));

            var items = library.GetCatalogItems();
            
            Assert.Equal(4, items.Count());
        }


        [Fact]
        public void GetCatalogItems_GetByDigitalMedia_ReturnsOnlyDigitalMedia()
        {
            var library = new WeltecLibrary();

            library.Add(new DigitalMedia("The Tree2"));
            library.Add(new Book("The Tree0"));
            library.Add(new Article("The Tree1"));
            library.Add(new DigitalMedia("The Tree4"));

            var items = library.GetCatalogItems<DigitalMedia>();

            Assert.Equal(2, items.Count());
        }
    }
}