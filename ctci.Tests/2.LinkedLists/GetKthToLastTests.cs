using ctci._2.LinkedLists;

namespace citi.Tests._2.LinkedLists
{
    public partial class LinkedListsTests

    {
        [Fact]
        public void CanGetKthToLastNode()
        {
            // Arrange
            var getKthToLast = new GetKthToLast();
            var k = 3;
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(4);
            node.appendToTail(5);
            node.appendToTail(6);

            var expectedData = 3;

            // Act
            var actualResult = getKthToLast.GetNodeFromEnd(node, k);

            // Assert
            Assert.Equal(expectedData, actualResult.data);
        }

        [Fact]
        public void CanGetKthToLastNodeIfLast()
        {
            // Arrange
            var getKthToLast = new GetKthToLast();
            var k = 0;
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(4);
            node.appendToTail(5);
            node.appendToTail(6);

            var expectedData = 6;

            // Act
            var actualResult = getKthToLast.GetNodeFromEnd(node, k);

            // Assert
            Assert.Equal(expectedData, actualResult.data);
        }

        [Fact]
        public void CanNOTGetKthToLastNodeIfBiggerThanListSize()
        {
            // Arrange
            var getKthToLast = new GetKthToLast();
            var k = 100;
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(4);
            node.appendToTail(5);
            node.appendToTail(6);

            var expectedData = (int?)null;

            // Act
            var actualResult = getKthToLast.GetNodeFromEnd(node, k);

            // Assert
            Assert.Equal(expectedData, actualResult?.data);
        }
    }
}