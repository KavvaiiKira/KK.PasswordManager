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

            PasswordService? passwordService;
            string? name;

            var userService = new UserService();
            var hashService = new HashService();

            ApplicationConfiguration.Initialize();

            if (userService.IsNewUser())
            {
                var registerForm = new RegisterForm(hashService);

                registerForm.ShowDialog();

                var registeredUser = registerForm.GetUser();
                var driveKey = registerForm.GetDriveKey();

                if (registeredUser == null || driveKey == null)
                {
                    return;
                }

                userService.SaveUser(registeredUser);
                passwordService = new PasswordService(driveKey, registeredUser.IV);
                name = registeredUser.Name;
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

                passwordService = new PasswordService(
                    hashService.GetDeriveKey(PIN, salt),
                    user.IV);

                name = user.Name;
            }

            Application.Run(new MainForm(passwordService, name));
        }
    }
}