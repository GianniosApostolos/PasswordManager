using System;
using System.IO;
using System.Security.Cryptography;

namespace PasswordManager.Scripts
{
    internal class AesEncryption
    {

        public static byte[] Encrypt(string plainText, byte[] key)
        {
            byte[] encryptedText;
            byte[] iv;

            using (Aes aesAlg = Aes.Create())
            {

                aesAlg.GenerateIV();
                iv = aesAlg.IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(key, iv);

                using (MemoryStream msEncrypt = new MemoryStream())
                {

                    // Write the IV to the beginning of the stream
                    msEncrypt.Write(iv, 0, iv.Length);

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encryptedText = msEncrypt.ToArray();
                    }
                }

            }
            return encryptedText;
        }

        public static string Decrypt(byte[] encryptedText, byte[] key)
        {
            string decryptedText = String.Empty;
            byte[] iv = new byte[16]; // AES block size is 16 bytes

            using (MemoryStream msDecrypt = new MemoryStream(encryptedText))
            {
                // Extract the IV from the beginning of the encrypted text
                msDecrypt.Read(iv, 0, iv.Length);

                using (Aes aesAlg = Aes.Create())
                {
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(key, iv);

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return decryptedText;
        }
    }

}
