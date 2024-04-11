namespace citi.Tests._1.Strings
{
    using ctci._1.Strings;

    public class StringRotationTests
    {
        [Theory]
        [InlineData("abcd", "cdab", true)]
        [InlineData("waterbottle", "erbottlewat", true)]
        [InlineData("abc", "ab", false)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "vwxyzabcd", false)]
        [InlineData("abc", "z", false)]
        [InlineData("abc", "cba", false)]
        public void RotatesStringAsExpected(string originalString, string possibleRotation, bool expectedIsRotation)
        {
            // Arrange
            var stringRotation = new StringRotation();

            // Act
            var actualIsRotation = stringRotation.IsRotation(originalString, possibleRotation);

            // Assert
            Assert.Equal(expectedIsRotation, actualIsRotation);
        }
    }
}