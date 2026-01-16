using KK.PasswordManager.Forms;
using KK.PasswordManager.Services;

namespace KK.PasswordManager
{
    public partial class MainForm : Form
    {
        private readonly PasswordService _passwordService;

        public MainForm(
            PasswordService passwordService,
            string name)
        {
            _passwordService = passwordService;

            InitializeComponent();

            NameLabel.Text = name;
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            var addPasswordForm = new AddPasswordForm();

            if (addPasswordForm.ShowDialog() != DialogResult.OK)
            {
                return; 
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Length < 3)
            {
                return;
            }
        }
    }
}
