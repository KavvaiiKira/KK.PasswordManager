using KK.PasswordManager.Models;
using KK.PasswordManager.Services;

namespace KK.PasswordManager
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private readonly PasswordService _passwordService;
        private readonly User _user;

        public MainForm(
            PasswordService passwordService,
            UserService userService,
            User user)
        {
            _passwordService = passwordService;
            _userService = userService;
            _user = user;

            InitializeComponent();
        }
    }
}
