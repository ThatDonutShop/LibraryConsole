using Library.Core;

namespace Library.WinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var library = LoadInitialData();
            Application.Run(new LoginForm(library));
        }

        private static WeltecLibrary LoadInitialData()
        {
            var library = new WeltecLibrary();
            var clock = new SystemClock();

            // items borrowed by student Noah
            var noah = new Student { FirstName = "Noah", LastName = "Rogers", Password = "password", Email = "noah@gmail.com" };
            library.Add(noah);

            var monster = new Book("The Monster");
            library.Add(monster);

            var tree = new Book("The Tree");
            library.Add(tree);

            var howTo = new Article("How To");
            library.Add(howTo);

            var breakingNews = new Article("Breaking News");
            library.Add(breakingNews);

            var guide = new DigitalMedia("Guide to Eating");
            library.Add(guide);

            noah.BorrowItem(monster, clock);
            noah.BorrowItem(tree, clock);
            noah.BorrowItem(howTo, clock);
            noah.BorrowItem(breakingNews, clock);
            noah.BorrowItem(guide, clock);

            // items borrowed by staff member Jim
            var jim = new Staff { FirstName = "Jim", LastName = "Smith", Password = "password", Email = "jim.smith@gmail.com" };
            library.Add(jim);

            var egg = new Book("The Egg");
            library.Add(egg);

            var recipe = new Article("Recipes");
            library.Add(recipe);

            jim.BorrowItem(egg, clock);
            jim.BorrowItem(recipe, clock);

            // items unborrowed
            var journey = new Book("The Journey Within");
            library.Add(journey);

            var mystery = new Book("The Mystery of Midnight Manor");
            library.Add(mystery);

            var healthTips = new Article("10 Health Tips for a Better You");
            library.Add(healthTips);

            var spaceDiscovery = new Article("Space Exploration: The Next Frontier");
            library.Add(spaceDiscovery);

            var fitnessVideo = new DigitalMedia("Fitness at Home: A Beginner's Guide");
            library.Add(fitnessVideo);

            var cookingTutorial = new DigitalMedia("Cooking Mastery: From Novice to Chef");
            library.Add(cookingTutorial);

            return library;
        }
    }
}
