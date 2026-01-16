using KK.PasswordManager.Constants;
using KK.PasswordManager.Forms;
using KK.PasswordManager.Services;

namespace KK.PasswordManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var dataDirectory = Path.Combine(
                AppContext.BaseDirectory,
                FileConstants.DATA_FOLDER_NAME);

            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }

            var passwordService = new PasswordService();
            var userService = new UserService();

            ApplicationConfiguration.Initialize();

            if (userService.IsNewUser())
            {
                var registerForm = new RegisterForm();

                registerForm.ShowDialog();

                var user = registerForm.GetUser();
                if (user == null)
                {
                    return;
                }
                else
                {
                    userService.SaveUser(user!);
                }
            }
            else
            {
                var PINENterForm = new PINEnterForm();

                PINENterForm.ShowDialog();

                var PIN = PINENterForm.GetPIN();
                if (string.IsNullOrWhiteSpace(PIN) ||
                    !userService.IsPINValid(PIN))
                {
                    return;
                }
            }

            Application.Run(
                new MainForm(
                    passwordService,
                    userService));
        }
    }
}