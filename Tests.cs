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
        public void Encrypt_ShouldReturnEncryptedText()
        {
            var input = "abc";
            var expected = "def";

            var result = _encryptionService.Encrypt(input);

            Assert.Equal(expected, result);
        }
    }
}
