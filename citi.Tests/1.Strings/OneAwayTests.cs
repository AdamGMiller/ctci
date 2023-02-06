using ctci._1.Strings;

namespace citi.Tests
{
    public partial class StringTests
    {
        [Theory]
        [InlineData("pale", "ple", true)]
        [InlineData("pale", "ple", true)]
        [InlineData("pale", "ple", true)]
        public void OneAway(string initial, string modified, bool expectedResult)
        {
            // Arrange
            var oneAway = new OneAway();

            // Act
            var actualResult = oneAway.IsOneAway(initial, modified);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}