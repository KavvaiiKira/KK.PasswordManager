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
            var hashService = new HashService();

            ApplicationConfiguration.Initialize();

            byte[]? driveKey;

            if (userService.IsNewUser())
            {
                var registerForm = new RegisterForm(hashService);

                registerForm.ShowDialog();

                var registeredUser = registerForm.GetUser();
                driveKey = registerForm.GetDriveKey();

                if (registeredUser == null ||
                    driveKey == null)
                {
                    return;
                }
                else
                {
                    userService.SaveUser(registeredUser);
                }
            }
            else
            {
                var user = userService.GetSavedUser();
                var PINENterForm = new PINEnterForm();

                PINENterForm.ShowDialog();

                var PIN = PINENterForm.GetPIN();
                if (string.IsNullOrWhiteSpace(PIN))
                {
                    return;
                }

                var splitted = user.PIN.Split(':');
                var salt = splitted.First();
                var hashedPIN = hashService.HashWithSalt(PIN, splitted.First());

                if (!hashService.IsPINValid(hashedPIN, splitted.Last()))
                {
                    return;
                }

                driveKey = hashService.GetDeriveKey(PIN, salt);
            }

            Application.Run(
                new MainForm(
                    passwordService,
                    driveKey!));
        }
    }
}