using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace VideoLibrary
{
    public static class PasswordManager
    {
        private static string passwordFile = "admin_pwd.dat";

        public static void SavePassword(string password)
        {
            string hash = ComputeSha256Hash(password);
            File.WriteAllText(passwordFile, hash);
        }

        public static bool VerifyPassword(string password)
        {
            if (!File.Exists(passwordFile)) return false;
            string storedHash = File.ReadAllText(passwordFile);
            string inputHash = ComputeSha256Hash(password);
            return storedHash == inputHash;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}