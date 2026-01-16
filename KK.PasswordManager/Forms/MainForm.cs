using KK.PasswordManager.Services;

namespace KK.PasswordManager
{
    public partial class MainForm : Form
    {
        private readonly PasswordService _passwordService;

        public MainForm(
            PasswordService passwordService)
        {
            _passwordService = passwordService;

            InitializeComponent();
        }
    }
}
