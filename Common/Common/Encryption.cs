using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CSharp.CommonUtilities
{
    public static class Encryption
    {
        public static string Encrypt(string secureUserData, string SecurityKey)
        {
            byte[] bytesBuff = Encoding.Unicode.GetBytes(secureUserData);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(SecurityKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    secureUserData = Convert.ToBase64String(mStream.ToArray());
                }
            }
            return secureUserData;
        }

        public static string Decrypt(string cipherString, string SecurityKey)
        {
            cipherString = cipherString.Replace(" ", "+");
            byte[] bytesBuff = Convert.FromBase64String(cipherString);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes crypto = new Rfc2898DeriveBytes(SecurityKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = crypto.GetBytes(32);
                aes.IV = crypto.GetBytes(16);
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (CryptoStream cStream = new CryptoStream(mStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cStream.Write(bytesBuff, 0, bytesBuff.Length);
                        cStream.Close();
                    }
                    cipherString = Encoding.Unicode.GetString(mStream.ToArray());
                }
            }
            return cipherString;
        }
    }
}
