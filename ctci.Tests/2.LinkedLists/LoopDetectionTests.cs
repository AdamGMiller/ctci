using ctci._2.LinkedLists;

namespace citi.Tests._2.LinkedLists
{
    public partial class LinkedListsTests

    {
        [Fact]
        public void LoopDetectionFoundCorrectly()
        {
            // Arrange
            var loopDetection = new LoopDetection();
            var node = new Node(1);
            node.appendToTail(2);
            node.next.next = node.next;

            var expectedResult = node.next;

            // Act
            var actualResult = loopDetection.GetLoopingNode(node);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void LoopDetectionNotFoundCorrectly()
        {
            // Arrange
            var loopDetection = new LoopDetection();
            var node = new Node(1);
            node.appendToTail(2);
            node.appendToTail(3);
            node.appendToTail(2);
            node.appendToTail(1);

            var expectedResult = (Node?)null;

            // Act
            var actualResult = loopDetection.GetLoopingNode(node);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}