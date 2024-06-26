namespace citi.Tests._1.Strings
{
    using ctci._1.Strings;

    public class UniqueStringTests
    {
        [Theory]
        [InlineData("abc", true)]
        [InlineData("abcdefghijklmnopqrstuvwxyz", true)]
        [InlineData("!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~", true)]
        [InlineData("AaBbCc", true)]
        [InlineData("aaa", false)]
        [InlineData("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", false)]
        [InlineData("AaAa", false)]
        [InlineData("!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~", false)]
        public void ReturnsUniqueString(string input, bool expectedIsUnique)
        {
            // Arrange
            var uniqueString = new UniqueString();

            // Act
            var actualIsUnique = uniqueString.IsUnique(input);

            // Assert
            Assert.Equal(expectedIsUnique, actualIsUnique);
        }
    }
}