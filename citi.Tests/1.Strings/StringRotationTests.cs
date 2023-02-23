using ctci._1.Strings;

namespace citi.Tests._1.Strings
{
    public partial class StringTests
    {
        [Theory]
        [InlineData("abcd", "cdab", true)]
        [InlineData("waterbottle", "erbottlewat", true)]
        [InlineData("abc", "ab", false)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", "vwxyzabcd", false)]
        [InlineData("abc", "z", false)]
        [InlineData("abc", "cba", false)]
        public void StringRotationTests(string originalString, string possibleRotation, bool expectedIsRotation)
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