using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HASTANE
{
    internal class HashIslemleri
    {
        public static byte[] CreateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var buff = new byte[16];
                rng.GetBytes(buff);
                return buff;
            }
        }

        public static string ByteArrayToString(byte[] inputArray)
        {
            return BitConverter.ToString(inputArray).Replace("-", string.Empty);
        }

        public static string CreatePasswordHash(string password, byte[] salt)
        {
            // Combine password and salt
            var saltAndPwd = CombinePasswordAndSalt(password, salt);
            using (var sha256 = SHA256.Create())
            {
                var hashedDataBytes = sha256.ComputeHash(saltAndPwd);
                return ByteArrayToString(hashedDataBytes);
            }
        }

        private static byte[] CombinePasswordAndSalt(string password, byte[] salt)
        {
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var combined = new byte[passwordBytes.Length + salt.Length];

            Buffer.BlockCopy(passwordBytes, 0, combined, 0, passwordBytes.Length);
            Buffer.BlockCopy(salt, 0, combined, passwordBytes.Length, salt.Length);

            return combined;
        }

        public static bool SifreKontrolEt(string girilenSifre, string gercekSifreHash, byte[] salt)
        {
            try
            {
                gercekSifreHash = gercekSifreHash.Trim();
                string hashOfInputPassword = CreatePasswordHash(girilenSifre, salt);
                bool areEqual = hashOfInputPassword.Equals(gercekSifreHash, StringComparison.OrdinalIgnoreCase);

                return areEqual;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return false;
            }
        }
    }
}
