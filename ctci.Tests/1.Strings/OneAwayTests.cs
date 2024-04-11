namespace citi.Tests._1.Strings
{
    using ctci._1.Strings;

    public class OneAwayTests
    {
        [Theory]
        [InlineData("pale", "pale", true)]
        [InlineData("pale", "ple", true)]
        [InlineData("pales", "pale", true)]
        [InlineData("pale", "bale", true)]
        [InlineData("pale", "pales", true)]
        [InlineData("ale", "kale", true)]
        [InlineData("", "a", true)]
        [InlineData("a", "", true)]
        [InlineData("pale", "bake", false)]
        [InlineData("le", "bake", false)]
        public void ChecksOneAway(string initial, string modified, bool expectedResult)
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