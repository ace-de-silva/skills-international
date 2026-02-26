using System;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (DatabaseHelper.ValidateLogin(username, password))
            {
                RegistrationForm regForm = new RegistrationForm(this);
                this.Hide();
                regForm.Show();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Login credentials, please check Username and Password and try again",
                    "Invalid login Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
