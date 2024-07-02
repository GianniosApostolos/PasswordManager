using System.Text;

namespace PasswordManager.Helper
{
    internal static class DeriveKey
    {
        public static byte[] Derive(string password, int keySize)
        {
            // Turn the first 8 digits of the password to Salt
            byte[] salt = Encoding.UTF8.GetBytes(password.Substring(0, 8));

            using (var rfc2898DeriveBytes = new System.Security.Cryptography.Rfc2898DeriveBytes(password, salt, 10000))
            {
                return rfc2898DeriveBytes.GetBytes(keySize);
            }

        }

    }
}
