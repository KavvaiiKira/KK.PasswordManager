using KK.PasswordManager.Services;

namespace KK.PasswordManager
{
    public partial class MainForm : Form
    {
        private readonly PasswordService _passwordService;
        private readonly byte[] _driveKey;

        public MainForm(
            PasswordService passwordService,
            byte[] driveKey)
        {
            _passwordService = passwordService;
            _driveKey = driveKey;

            InitializeComponent();
        }
    }
}
