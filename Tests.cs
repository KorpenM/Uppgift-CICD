using cicdApi;
using Xunit;

namespace cicdApi
{
    public class Tests
    {
        private readonly EncryptionService _encryptionService;

        public Tests()
        {
            // Skapa en instans av EncryptionService med en nyckel
            _encryptionService = new EncryptionService(3); // Caesar Cipher med nyckel 3
        }

        [Fact]
        public void Encrypt_ShouldReturnEncrypted()
        {
            var input = "abc";
            var expected = "def";

            var result = _encryptionService.Encrypt(input);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Decrypt_ShouldReturnOriginalToOriginal()
        {
            var input = "def"; // Krypterad version av "abc" med nyckel 3
            var expected = "abc";

            var result = _encryptionService.Decrypt(input);

            Assert.Equal(expected, result);

        }
    }
}
