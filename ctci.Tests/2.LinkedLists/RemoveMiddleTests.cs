namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public partial class RemoveMiddleTests
    {
        [Fact]
        public void CanRemoveMiddleFromSimpleList()
        {
            // Arrange
            var removeMiddle = new RemoveMiddle();
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(4);

            var nodeInMiddle = node?.next;

            var expectedResult = new Node(1);
            expectedResult.appendToTail(3);
            expectedResult.appendToTail(4);

            // Act
            var actualResult = removeMiddle.RemoveItemFromLinkedList(nodeInMiddle);

            // Assert
            Assert.True(actualResult);
            Assert.Equal(expectedResult.GetData(), node.GetData());
        }

        [Fact]
        public void CanNotRemoveMiddleFromLast()
        {
            // Arrange
            var removeMiddle = new RemoveMiddle();
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(4);

            var nodeInMiddle = node?.next?.next?.next;

            var expectedResult = new Node(1);

            // Act
            var actualResult = removeMiddle.RemoveItemFromLinkedList(nodeInMiddle);

            // Assert
            Assert.False(actualResult);
        }
    }
}