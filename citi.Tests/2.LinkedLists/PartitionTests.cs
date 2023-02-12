using ctci._2.LinkedLists;

namespace citi.Tests
{
    public partial class LinkedListsTests

    {
        [Fact]
        public void CanPartitionAroundValue()
        {
            // Arrange
            var partition = new Partition();
            var node = new Node(8);
            node.appendToTail(2);
            node.appendToTail(9);
            node.appendToTail(4);

            var value = 5;

            var expectedResult = new Node(2);
            expectedResult.appendToTail(4);
            expectedResult.appendToTail(8);
            expectedResult.appendToTail(9);

            // Act
            var actualResult = partition.PartitionAroundValue(node, value);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }

        [Fact]
        public void CanPartitionAroundSingleValue()
        {
            // Arrange
            var partition = new Partition();
            var node = new Node(8);

            var value = 5;

            var expectedResult = new Node(8);

            // Act
            var actualResult = partition.PartitionAroundValue(node, value);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }
    }
}