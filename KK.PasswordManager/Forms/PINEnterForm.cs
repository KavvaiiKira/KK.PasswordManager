using KK.PasswordManager.Services;

namespace KK.PasswordManager.Forms
{
    public partial class PINEnterForm : Form
    {
        private readonly HashService _hashService;

        private string? PIN;

        public PINEnterForm()
        {
            _hashService = new HashService();
            InitializeComponent();
        }

        public string? GetPIN() => PIN;

        private void PINEnterForm_Shown(object sender, EventArgs e) => PINTextBox.Focus();

        private void PINTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PIN = _hashService.HashWithStringSalt(PINTextBox.Text, PINTextBox.Text);
                Close();
            }
        }
    }
}
