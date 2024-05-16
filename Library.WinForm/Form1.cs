using Library.Core;
using Microsoft.VisualBasic.Devices;

namespace Library.WinForm
{
    public partial class Form1 : Form
    {
        private readonly WeltecLibrary _library = new();
        private readonly IClock _clock = new SystemClock();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInitialData();
            Students.DataSource = _library.Members;
        }

        private void LoadInitialData()
        {
            var noah = new Student { FirstName = "Noah", LastName = "Rogers" };
            _library.Add(noah);

            var monster = new Book("The Monster");
            _library.Add(monster);

            var tree = new Book("The tree");
            _library.Add(tree);

            var howTo = new Article("How To");
            _library.Add(howTo);

            var breakingNews = new Article("Breaking News");
            _library.Add(breakingNews);

            var guide = new DigitalMedia("Guide to Eating");
            _library.Add(guide);

            noah.BorrowItem(monster, _clock);
            noah.BorrowItem(tree, _clock);
            noah.BorrowItem(howTo, _clock);
            noah.BorrowItem(breakingNews, _clock);
            noah.BorrowItem(guide, _clock);

            var jim = new Staff { FirstName = "Jim", LastName = "Smith" };
            _library.Add(jim);

            var egg = new Book("The egg");
            _library.Add(egg);

            var recipe = new Article("Recipes");
            _library.Add(recipe);

            jim.BorrowItem(egg, _clock);
            jim.BorrowItem(recipe, _clock);

            // items unborrowed
            var journey = new Book("The Journey Within");
            _library.Add(journey);

            var mystery = new Book("The Mystery of Midnight Manor");
            _library.Add(mystery);

            var healthTips = new Article("10 Health Tips for a Better You");
            _library.Add(healthTips);

            var spaceDiscovery = new Article("Space Exploration: The Next Frontier");
            _library.Add(spaceDiscovery);

            var fitnessVideo = new DigitalMedia("Fitness at Home: A Beginner's Guide");
            _library.Add(fitnessVideo);

            var cookingTutorial = new DigitalMedia("Cooking Mastery: From Novice to Chef");
            _library.Add(cookingTutorial);
        }

        private void Students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
