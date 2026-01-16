using KK.PasswordManager.Constants;

namespace KK.PasswordManager.Services
{
    public class PasswordService
    {
        private readonly string _passwordsFilePath;

        public PasswordService()
        {
            _passwordsFilePath = Path.Combine(
                AppContext.BaseDirectory,
                FileConstants.DATA_FOLDER_NAME,
                FileConstants.PASSWORDS_FILE_NAME);

            if (!File.Exists(_passwordsFilePath))
            {
                File.WriteAllText(_passwordsFilePath, string.Empty);
            }
        }
    }
}
