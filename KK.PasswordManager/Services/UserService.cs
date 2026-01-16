using KK.PasswordManager.Constants;
using KK.PasswordManager.Models;
using System.Text.Json;

namespace KK.PasswordManager.Services
{
    public class UserService
    {
        private readonly string _userFilePath;

        public UserService()
        {
            _userFilePath = Path.Combine(
                AppContext.BaseDirectory,
                FileConstants.DATA_FOLDER_NAME,
                FileConstants.USER_FILE_NAME);
        }

        public bool IsNewUser() =>
            !File.Exists(_userFilePath) ?
                true :
                string.IsNullOrWhiteSpace(File.ReadAllText(_userFilePath));

        public void SaveUser(User user) =>
            File.WriteAllText(_userFilePath, JsonSerializer.Serialize(user));

        public bool IsPINValid(string PIN) =>
            PIN == (JsonSerializer.Deserialize<User>(File.ReadAllText(_userFilePath)) ??
                throw new Exception("Can't deserialize user!")).PIN;
    }
}
