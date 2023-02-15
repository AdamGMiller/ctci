using ctci._2.LinkedLists;

namespace citi.Tests
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

            var expectedResult = new Node(1);
            expectedResult.appendToTail(4);
            expectedResult.appendToTail(3);
            expectedResult.appendToTail(3);

            // Act
            var actualResult = sumLists.SumNumbersStoredInReverseOrder(firstNode, secondNode);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }
    }
}