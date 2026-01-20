using KK.PasswordManager.Components;
using KK.PasswordManager.Forms;
using KK.PasswordManager.Models;
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

            LoadPasswords();
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            var addPasswordForm = new AddPasswordForm();
            var dialogResult = addPasswordForm.ShowDialog();
            var passwordToAdd = addPasswordForm.GetPassword();

            if (dialogResult != DialogResult.OK ||
                passwordToAdd == null)
            {
                return; 
            }

            _passwordService.AddPassword(passwordToAdd);

            LoadPassword(passwordToAdd);
        }

        private void LoadPasswords()
        {
            var passwords = _passwordService.GetPasswords();

            foreach (var password in passwords)
            {
                LoadPassword(password);
            }

            PasswordsPanel.Refresh();
        }

        private void LoadPassword(PasswordModel password)
        {
            var passwordGroup = new PasswordGroup(password);

            PasswordsPanel.Controls.Add(passwordGroup);
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
