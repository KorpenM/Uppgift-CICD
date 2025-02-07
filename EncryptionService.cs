using System;
using System.Text;

namespace cicdApi
{
    public class EncryptionService
    {
        private int _key;
        private static Random _random = new Random();

        public EncryptionService(int key)
        {
            _key = key;
        }

        // Krypterar texten genom att använda Caesar Cipher
        public string Encrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))  // Stödjer nu både bokstäver och siffror
                {
                    var start = char.IsUpper(c) ? 'A' : char.IsLower(c) ? 'a' : '0';
                    int range = char.IsDigit(c) ? 10 : 26;
                    result.Append((char)((((c - start + _key) + range) % range) + start));
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        // Avkrypterar texten genom att använda Caesar Cipher (använder negativ nyckel)
        public string Decrypt(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    var start = char.IsUpper(c) ? 'A' : char.IsLower(c) ? 'a' : '0';
                    int range = char.IsDigit(c) ? 10 : 26;
                    result.Append((char)((((c - start - _key) + range) % range) + start));
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }

        // Genererar ett slumpmässigt lösenord med 10 tecken (bokstäver och siffror)
        public string GenerateRandomPassword(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                password.Append(chars[_random.Next(chars.Length)]);
            }
            return password.ToString();
        }
    }
}
