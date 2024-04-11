using ctci._2.LinkedLists;

namespace citi.Tests._2.LinkedLists
{
    public partial class LinkedListsTests
    {
        [Fact]
        public void CanSumLists()
        {
            // Arrange
            var sumLists = new SumLists();
            var firstNode = new Node(5);
            firstNode.appendToTail(2);
            firstNode.appendToTail(5);
            var secondNode = new Node(9);
            secondNode.appendToTail(0);
            secondNode.appendToTail(8);

            var expectedResult = new Node(4);
            expectedResult.appendToTail(3);
            expectedResult.appendToTail(3);
            expectedResult.appendToTail(1);

            // Act
            var actualResult = sumLists.SumNumbersStoredInReverseOrder(firstNode, secondNode);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }

        [Fact]
        public void CanSumDifferentLengthLists()
        {
            // Arrange
            var sumLists = new SumLists();
            var firstNode = new Node(1);
            var secondNode = new Node(9);
            secondNode.appendToTail(0);
            secondNode.appendToTail(8);

            var expectedResult = new Node(0);
            expectedResult.appendToTail(1);
            expectedResult.appendToTail(8);

            // Act
            var actualResult = sumLists.SumNumbersStoredInReverseOrder(firstNode, secondNode);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }
    }
}