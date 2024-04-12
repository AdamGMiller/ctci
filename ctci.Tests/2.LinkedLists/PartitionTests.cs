namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class PartitionTests
    {
        [Fact]
        public void CanPartitionAroundValue()
        {
            // Arrange
            var partition = new Partition();
            var node = new Node(8);
            node.AppendToTail(2);
            node.AppendToTail(9);
            node.AppendToTail(4);

            var value = 5;

            var expectedResult = new Node(2);
            expectedResult.AppendToTail(4);
            expectedResult.AppendToTail(8);
            expectedResult.AppendToTail(9);

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