using ctci._1.Strings;

namespace citi.Tests
{
    public partial class StringTests
    {
        [Theory]
        [InlineData("Test input here      ", 13, "Test%20input%20here")]
        public void UrlifyTests(string input, int stringLength, string expectedOutput)
        {
            // Arrange
            var urlifiedString = new Urlify();

            // Act
            var actualOutput = urlifiedString.ToUrl(input, stringLength);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}