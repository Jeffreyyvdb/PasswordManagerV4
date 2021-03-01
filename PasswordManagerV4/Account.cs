using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerV4
{
    // https://www.youtube.com/watch?v=AU-4oLUV5VU

    public class Account
    {
        public string username { get; set; }
        public string salt { get; set; }
        public string hashedPassword { get; set; }

        public Account(string username, string password)
        {
            this.username = username;
            salt = CreateSalt(50);
            hashedPassword = GenerateSHA256Hash(password, salt);


        }

        // Create Salt, string met willekeurige waarden
        public static String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            Byte[] buff = new byte[size];

            // Vult Byte array met willekeurige waarden
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        // Hash password + salt
        static public string GenerateSHA256Hash(string input,string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(bytes);
        }

        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static string Encrypt(string toEncrypt, string keyHash)
        {
            string encrypted;
            byte[] data = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(keyHash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return encrypted = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string Decrypt(string toDecrypt, string keyHash)
        {
            byte[] data = Convert.FromBase64String(toDecrypt);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(keyHash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return toDecrypt = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
