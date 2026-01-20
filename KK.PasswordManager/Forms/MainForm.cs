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

            LoadPassword(passwordToAdd, DeletePassword);
        }

        private void DeletePassword(int passwordId, string name)
        {
            _passwordService.DeletePassword(passwordId);

            var passwordGroupToRemove = PasswordsPanel.Controls
                .Cast<PasswordGroup>()
                .First(pg => pg.GetId() == passwordId);
           
            PasswordsPanel.Controls.Remove(passwordGroupToRemove);

            if (PasswordsPanel.Controls.Count == 0)
            {
                return;
            }

            var passwordGroups = PasswordsPanel.Controls
                .Cast<PasswordGroup>()
                .Where(pg => pg.GetId() > passwordId);

            foreach (var passwordGroup in passwordGroups)
            {
                passwordGroup.SetId(passwordGroup.GetId() - 1);
            }
        }

        private void LoadPasswords()
        {
            var passwords = _passwordService.GetPasswords();

            foreach (var password in passwords)
            {
                password.Password = _passwordService.DecryptToString(password.Password);

                LoadPassword(password, DeletePassword);
            }

            PasswordsPanel.Refresh();
        }

        private void LoadPassword(PasswordModel password, Action<int, string> deletePassword)
        {
            var passwordGroup = new PasswordGroup(password, deletePassword);

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
