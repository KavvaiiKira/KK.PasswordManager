using KK.PasswordManager.Constants;
using KK.PasswordManager.Forms;
using KK.PasswordManager.Models;
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

            User? user;

            if (userService.IsNewUser())
            {
                var registerForm = new RegisterForm();

                registerForm.ShowDialog();

                var registeredUser = registerForm.GetUser();
                if (registeredUser == null)
                {
                    return;
                }
                else
                {
                    userService.SaveUser(registeredUser!);
                    user = registeredUser;
                }
            }
            else
            {
                user = userService.GetSavedUser();

                var PINENterForm = new PINEnterForm();

                PINENterForm.ShowDialog();

                var PIN = PINENterForm.GetPIN();
                if (string.IsNullOrWhiteSpace(PIN) ||
                    PIN != user.PIN)
                {
                    return;
                }
            }

            if (user == null)
            {
                return;
            }

            Application.Run(
                new MainForm(
                    passwordService,
                    userService,
                    user));
        }
    }
}