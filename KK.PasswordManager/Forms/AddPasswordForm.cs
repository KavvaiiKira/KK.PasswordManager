using KK.PasswordManager.Models;

namespace KK.PasswordManager.Forms
{
    public partial class AddPasswordForm : Form
    {
        private PasswordModel? password;

        public AddPasswordForm()
        {
            InitializeComponent();
        }

        public PasswordModel? GetPassword() => password;

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(UserNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                return;
            }

            password = new PasswordModel()
            {
                Name = NameTextBox.Text,
                Site = SiteTextBox.Text ?? string.Empty,
                UserName = UserNameTextBox.Text,
                Password = PasswordTextBox.Text
            };

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddPasswordForm_Shown(object sender, EventArgs e)
        {
            NameTextBox.Focus();
        }
    }
}
