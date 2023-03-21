using ctci._1.Strings;

namespace citi.Tests._1.Strings
{
    public partial class StringTests
    {
        [Theory]
        [InlineData("abc", "acb", true)]
        [InlineData("abc", "123412341230498y7210983471029837410298374102983741029384723094856720394578cba", true)]
        [InlineData("aaaaaaaaaaaaaaaaaaaaa", "aaaaaaaaaaaaaaaaaaaaa", true)]
        [InlineData("aaaaaaaaaaaaaaaaaaaaa", "bbaaaaaaaaaaaaaaaaaaaaacc", true)]
        [InlineData("1", "22", false)]
        [InlineData("1a", "!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~!#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~", false)]
        public void PermutationTests(string permutationString, string containingString, bool expectedIsPermutation)
        {
            // Arrange
            var permutation = new Permutation();

            // Act
            var actualIsPermutation = permutation.CheckInclusion(permutationString, containingString);

            // Assert
            Assert.Equal(expectedIsPermutation, actualIsPermutation);
        }
    }
}