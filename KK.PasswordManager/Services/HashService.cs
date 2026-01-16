using System.Security.Cryptography;

namespace KK.PasswordManager.Services
{
    public class HashService
    {
        private const int ITERATIONS = 310000; // OWASP 2023 for SHA256
        private const int KEY_SIZE = 32; // 256 bit for AES-256

        public string Hash(string input)
        {
            var salt = GenerateSalt();

            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(GetHash(input, salt))}";
        }

        public string HashWithSalt(string input, string saltString) =>
            Convert.ToBase64String(GetHash(input, Convert.FromBase64String(saltString)));

        public byte[] GetDeriveKey(string PIN, string salt)
        {
            var keySalt = SHA256.HashData(Convert.FromBase64String(salt));

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                PIN,
                keySalt,
                ITERATIONS,
                HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(KEY_SIZE);
            }
        }

        public byte[] GetIV() => GenerateSalt()[..16]; // 16 byte for AES

        public bool IsPINValid(string PIN, string savedPIN) =>
            SecureCompare(PIN, savedPIN);

        private byte[] GetHash(string input, byte[] salt)
        {
            using var pbkdf2 = new Rfc2898DeriveBytes(
                input,
                salt,
                ITERATIONS,
                HashAlgorithmName.SHA256);

            return pbkdf2.GetBytes(KEY_SIZE);
        }

        private static byte[] GenerateSalt()
        {
            var salt = new byte[KEY_SIZE];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        private static bool SecureCompare(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }

            return result == 0;
        }
    }
}
