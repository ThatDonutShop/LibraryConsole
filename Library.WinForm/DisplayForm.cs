using Library.Core;
using Microsoft.VisualBasic.Devices;

namespace Library.WinForm
{
    public partial class DisplayForm : Form
    {
        private readonly WeltecLibrary _library = new();
        private readonly IClock _clock = new SystemClock();

        public DisplayForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
