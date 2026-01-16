using System.Security.Cryptography;
using System.Text;

namespace KK.PasswordManager.Services
{
    public class HashService
    {
        private const int ITERATIONS = 310000; // OWASP 2023 for SHA256

        public string HashWithStringSalt(string input, string stringSalt)
        {
            var saltBytes = Encoding.UTF8.GetBytes(stringSalt);

            using var pbkdf2 = new Rfc2898DeriveBytes(
                input,
                saltBytes,
                ITERATIONS,
                HashAlgorithmName.SHA256);

            var hash = pbkdf2.GetBytes(32);

            return Convert.ToBase64String(hash);
        }
    }
}
