using PasswordManager.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordManager.Scripts
{
    internal static class StringGenerator
    {
        // KnuthShuffle
        public static StringBuilder ShuffleStringBuilder(StringBuilder stringBuilder)
        {
            System.Random random = new System.Random();

            for (int i = 0; i < stringBuilder.Length; i++)
            {
                // Don't select from the entire array on subsequent loops
                int j = random.Next(i, stringBuilder.Length);
                char temp = stringBuilder[i];
                stringBuilder[i] = stringBuilder[j];
                stringBuilder[j] = temp;
            }

            return stringBuilder;
        }

        public static string GeneratePassword(int passwordLength, Dictionary<PasswordTypes, bool> optionsDictionary)
        {
            StringBuilder passwordCharacters = new StringBuilder();

            if (optionsDictionary[PasswordTypes.ALL])
            {
                passwordCharacters.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+");
            }

            if (optionsDictionary[PasswordTypes.UPPERCASE])
            {
                passwordCharacters.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }

            if (optionsDictionary[PasswordTypes.LOWERCASE])
            {
                passwordCharacters.Append("abcdefghijklmnopqrstuvwxyz");
            }

            if (optionsDictionary[PasswordTypes.DIGITS])
            {
                passwordCharacters.Append("1234567890");
            }

            if (optionsDictionary[PasswordTypes.SYMBOLS])
            {
                passwordCharacters.Append("!@#$%^&*()_");
            }

            // Shuffle the initial password characters
            StringBuilder shuffledPasswordCharacters = ShuffleStringBuilder(passwordCharacters);

            // Reshuffle the password characters and return the generated password
            StringBuilder generatedPassword = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                generatedPassword.Append(shuffledPasswordCharacters[rnd.Next(0, shuffledPasswordCharacters.Length)]);
            }

            return generatedPassword.ToString();
        }
    }
}
