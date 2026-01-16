using KK.PasswordManager.Models;
using KK.PasswordManager.Services;

namespace KK.PasswordManager.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly HashService _hashService;

        private User? user;
        private byte[]? driveKey;

        public RegisterForm(HashService hashService)
        {
            _hashService = hashService;

            InitializeComponent();
        }

        public User? GetUser() => user;

        public byte[]? GetDriveKey() => driveKey;

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
                var hashedPIN = _hashService.Hash(PINTextBox.Text);

                user = new User()
                {
                    Name = NameTextBox.Text,
                    PIN = hashedPIN,
                    IV = _hashService.GetIV()
                };

                driveKey = _hashService.GetDeriveKey(
                    PINTextBox.Text,
                    hashedPIN.Split(':').First());

                Close();
            }
        }
    }
}
