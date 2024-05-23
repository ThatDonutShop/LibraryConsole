using Library.Core;

namespace Library.WinForm
{
    public partial class LoginForm : Form
    {
        private readonly WeltecLibrary _library;

        public LoginForm(WeltecLibrary library)
        {
            InitializeComponent();
            _library = library;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerAccountButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new(this);

            registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = emailAddressTextBox.Text;
            string password = passwordTextBox.Text;

            var member = _library.Members.FirstOrDefault(m => m.Email == email && m.Password == password);

            if (member != null)
            {
                MessageBox.Show("Login successful!");

                // TODO: Open the next form
                // NextForm nextForm = new NextForm();
                // nextForm.Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful!");
            }
        }
    }
}