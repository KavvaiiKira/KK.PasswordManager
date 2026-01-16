using KK.PasswordManager.Constants;
using System.Security.Cryptography;
using System.Text;

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

        private byte[] EncryptPassword(string password)
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

                    return ms.ToArray();
                }
            }
        }

        private string DecryptToString(byte[] cipherText)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _driveKey;
                aes.IV = _iv;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                using (var ms = new MemoryStream(cipherText))
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (var reader = new StreamReader(cs, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
