namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class GetKthToListTests
    {
        [Fact]
        public void CanGetKthToLastNode()
        {
            // Arrange
            var getKthToLast = new GetKthToLast();
            var k = 3;
            var node = new Node(1);
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(5);
            node.AppendToTail(6);

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
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(5);
            node.AppendToTail(6);

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
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(5);
            node.AppendToTail(6);

            var expectedData = (int?)null;

            // Act
            var actualResult = getKthToLast.GetNodeFromEnd(node, k);

            // Assert
            Assert.Equal(expectedData, actualResult?.data);
        }
    }
}