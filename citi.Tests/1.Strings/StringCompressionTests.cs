using ctci._1.Strings;

namespace citi.Tests
{
    public partial class StringTests
    {
        [Theory]
        [InlineData("abcd", "abcd")]
        [InlineData("aaabaa", "a3ba2")]
        [InlineData("aaa", "a3")]
        [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz")]
        [InlineData("AAaa", "A2a2")]
        [InlineData("", "")]
        public void StringCompressionTests(string input, string expectedOutput)
        {
            // Arrange
            var stringCompression = new StringCompression();

            // Act
            var actualOutput = stringCompression.CompressString(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}