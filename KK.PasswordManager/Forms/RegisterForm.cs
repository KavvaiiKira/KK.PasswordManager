using KK.PasswordManager.Models;
using KK.PasswordManager.Services;

namespace KK.PasswordManager.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly HashService _hashService;

        private User? user;

        public RegisterForm()
        {
            _hashService = new HashService();

            InitializeComponent();
        }

        public User? GetUser() => user;

        private void SubmitButton_Click(object sender, EventArgs e) => Submit();

        private void RegisterForm_Shown(object sender, EventArgs e) => NameTextBox.Focus();

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e) => HandleEnterKeyDown(e);

        private void PINTextBox_KeyDown(object sender, KeyEventArgs e) =>  HandleEnterKeyDown(e);

        private void HandleEnterKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }

        private void Submit()
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PINTextBox.Text))
            {
                user = new User()
                {
                    Name = NameTextBox.Text,
                    PIN = _hashService.HashWithStringSalt(PINTextBox.Text, PINTextBox.Text)
                };

                Close();
            }
        }
    }
}
