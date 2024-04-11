namespace citi.Tests._1.Strings
{
    using ctci._1.Strings;

    public class UrlifyTests
    {
        [Theory]
        [InlineData("Test input here      ", 13, "Test%20input%20here")]
        public void UrlifyWorksAsExpected(string input, int stringLength, string expectedOutput)
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