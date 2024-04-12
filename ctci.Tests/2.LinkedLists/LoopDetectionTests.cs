namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class LoopDetectionTests
    {
        [Fact]
        public void LoopDetectionFoundCorrectly()
        {
            // Arrange
            var loopDetection = new LoopDetection();
            var node = new Node(1);
            node.AppendToTail(2);
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
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(2);
            node.AppendToTail(1);

            var expectedResult = (Node?)null;

            // Act
            var actualResult = loopDetection.GetLoopingNode(node);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}