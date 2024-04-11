namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class PalindromeTests
    {
        [Fact]
        public void PanlindromeFoundCorrectly()
        {
            // Arrange
            var palindrome = new Palindrome();
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(2);
            node.appendToTail(1);

            var expectedResult = true;

            // Act
            var actualResult = palindrome.IsPalindrome(node);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void PanlindromeNotFoundCorrectly()
        {
            // Arrange
            var palindrome = new Palindrome();
            var node = new Node(9);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(2);
            node.appendToTail(1);

            var expectedResult = false;

            // Act
            var actualResult = palindrome.IsPalindrome(node);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}