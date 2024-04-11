namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class IntersectionTests
    {
        [Fact]
        public void IntersectionFoundCorrectly()
        {
            // Arrange
            var intersection = new Intersection();
            var firstNode = new Node(1);
            firstNode.appendToTail(2);
            firstNode.appendToTail(3);
            firstNode.appendToTail(2);
            firstNode.appendToTail(1);

            var secondNode = new Node(1);
            secondNode.appendToTail(2);
            secondNode.next.next = firstNode.next.next;
            secondNode.appendToTail(3);

            var expectedResult = firstNode.next.next;

            // Act
            var actualResult = intersection.GetIntersectingNode(firstNode, secondNode);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void IntersectionNotFoundCorrectly()
        {
            // Arrange
            var intersection = new Intersection();
            var firstNode = new Node(1);
            firstNode.appendToTail(2);
            firstNode.appendToTail(3);
            firstNode.appendToTail(2);
            firstNode.appendToTail(1);

            var secondNode = new Node(1);
            secondNode.appendToTail(2);
            secondNode.appendToTail(3);

            var expectedResult = (Node?)null;

            // Act
            var actualResult = intersection.GetIntersectingNode(firstNode, secondNode);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}