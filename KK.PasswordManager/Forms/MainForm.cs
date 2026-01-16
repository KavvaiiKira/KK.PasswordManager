using KK.PasswordManager.Forms;
using KK.PasswordManager.Services;

namespace KK.PasswordManager
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private readonly PasswordService _passwordService;

        public MainForm(
            PasswordService passwordService,
            UserService userService)
        {
            _passwordService = passwordService;
            _userService = userService;

            InitializeComponent();
        }
    }
}
