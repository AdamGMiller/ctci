using ctci._2.LinkedLists;

namespace citi.Tests._2.LinkedLists
{
    public partial class LinkedListsTests

    {
        [Fact]
        public void CanRemoveDupsFromSimpleList()
        {
            // Arrange
            var removeDups = new RemoveDups();
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(4);
            node.appendToTail(4);

            var expectedResult = new Node(1);
            expectedResult.appendToTail(2);
            expectedResult.appendToTail(3);
            expectedResult.appendToTail(4);

            // Act
            var actualResult = removeDups.GetUniqueItems(node);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }

        [Fact]
        public void CanRemoveDupsFromComplexList()
        {
            // Arrange
            var removeDups = new RemoveDups();
            var node = new Node(100);
            node.appendToTail(2);
            node.appendToTail(52);
            node.appendToTail(100);
            node.appendToTail(100);
            node.appendToTail(100);
            node.appendToTail(100);
            node.appendToTail(43);

            var expectedResult = new Node(100);
            expectedResult.appendToTail(2);
            expectedResult.appendToTail(52);
            expectedResult.appendToTail(43);

            // Act
            var actualResult = removeDups.GetUniqueItems(node);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }

        [Fact]
        public void CanRemoveDupsFromOnlyDuplicateList()
        {
            // Arrange
            var removeDups = new RemoveDups();
            var node = new Node(1);
            node.appendToTail(1);
            node.appendToTail(1);
            node.appendToTail(1);
            node.appendToTail(1);

            var expectedResult = new Node(1);

            // Act
            var actualResult = removeDups.GetUniqueItems(node);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }
    }
}