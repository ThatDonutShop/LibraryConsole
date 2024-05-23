using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinForm
{
    public partial class RegisterForm : Form
    {
        private LoginForm _loginForm;

        public RegisterForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void registerAlreadyHaveAccountButton_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }
    }
}
