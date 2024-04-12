namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class SumListsTests
    {
        [Fact]
        public void CanSumLists()
        {
            // Arrange
            var sumLists = new SumLists();
            var firstNode = new Node(5);
            firstNode.AppendToTail(2);
            firstNode.AppendToTail(5);
            var secondNode = new Node(9);
            secondNode.AppendToTail(0);
            secondNode.AppendToTail(8);

            var expectedResult = new Node(4);
            expectedResult.AppendToTail(3);
            expectedResult.AppendToTail(3);
            expectedResult.AppendToTail(1);

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
            secondNode.AppendToTail(0);
            secondNode.AppendToTail(8);

            var expectedResult = new Node(0);
            expectedResult.AppendToTail(1);
            expectedResult.AppendToTail(8);

            // Act
            var actualResult = sumLists.SumNumbersStoredInReverseOrder(firstNode, secondNode);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }
    }
}