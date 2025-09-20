namespace UNIR.TFE.Polyrepo.Shared.Test
{
    public class Base64UtilTests
    {
        [Fact]
        public void Encode_ShouldReturnBase64String()
        {
            // Arrange
            var plainText = "Hello, World!";
            var expectedBase64 = "SGVsbG8sIFdvcmxkIQ==";
            // Act
            var actualBase64 = Base64Util.Encode(plainText);
            // Assert
            Assert.Equal(expectedBase64, actualBase64);
        }
        [Fact]
        public void Decode_ShouldReturnPlainText()
        {
            // Arrange
            var base64EncodedData = "SGVsbG8sIFdvcmxkIQ==";
            var expectedPlainText = "Hello, World!";
            // Act
            var actualPlainText = Base64Util.Decode(base64EncodedData);
            // Assert
            Assert.Equal(expectedPlainText, actualPlainText);
        }
    }
}
