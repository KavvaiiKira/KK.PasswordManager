using KK.PasswordManager.Constants;
using KK.PasswordManager.Models;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace KK.PasswordManager.Services
{
    public class PasswordService
    {
        private readonly string _passwordsFilePath;
        private readonly byte[] _driveKey;
        private readonly byte[] _iv;

        public PasswordService(byte[] driveKey, byte[] iv)
        {
            _driveKey = driveKey;
            _iv = iv;

            _passwordsFilePath = Path.Combine(
                AppContext.BaseDirectory,
                FileConstants.DATA_FOLDER_NAME,
                FileConstants.PASSWORDS_FILE_NAME);

            if (!File.Exists(_passwordsFilePath))
            {
                File.WriteAllText(_passwordsFilePath, string.Empty);
            }
        }

        public IEnumerable<PasswordModel> GetPasswords()
        {
            var json = File.ReadAllText(_passwordsFilePath);
            var passwords = JsonSerializer.Deserialize<IEnumerable<PasswordModel>>(json);

            return passwords ?? Enumerable.Empty<PasswordModel>();
        }

        public void AddPassword(PasswordModel newPassword)
        {
            var passwords = GetPasswords().ToList();

            newPassword.Id = passwords.Any() ?
                passwords.Max(x => x.Id) + 1 :
                1;

            newPassword.Password = EncryptPassword(newPassword.Password);

            passwords.Add(newPassword);

            var json = JsonSerializer.Serialize(passwords);

            File.WriteAllText(_passwordsFilePath, json);
        }

        public void DeletePassword(int passwordId)
        {
            var passwords = GetPasswords().ToList();

            passwords.RemoveAll(x => x.Id == passwordId);

            foreach (var password in passwords.Where(s => s.Id > passwordId))
            {
                password.Id--;
            }

            var json = JsonSerializer.Serialize(passwords);

            File.WriteAllText(_passwordsFilePath, json);
        }

        private string EncryptPassword(string password)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _driveKey ;
                aes.IV = _iv;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                using (var encryptor = aes.CreateEncryptor())
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var writer = new StreamWriter(cs, Encoding.UTF8))
                    {
                        writer.Write(password);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private string DecryptToString(string cipherText)
        {
            var cipher = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                aes.Key = _driveKey;
                aes.IV = _iv;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                using (var ms = new MemoryStream(cipher))
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (var reader = new StreamReader(cs, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
