namespace citi.Tests._2.LinkedLists
{
    using ctci._2.LinkedLists;

    public class RemoveDupsTests
    {
        [Fact]
        public void CanRemoveDupsFromSimpleList()
        {
            // Arrange
            var removeDups = new RemoveDups();
            var node = new Node(1);
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(4);

            var expectedResult = new Node(1);
            expectedResult.AppendToTail(2);
            expectedResult.AppendToTail(3);
            expectedResult.AppendToTail(4);

            // Act
            var actualResult = removeDups.GetUniqueItems(node);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }

        [Fact]
        public void CanRemoveDupsFromComplexList()
        {
            // Arrange
            var removeDups = new RemoveDups();
            var node = new Node(100);
            node.AppendToTail(2);
            node.AppendToTail(52);
            node.AppendToTail(100);
            node.AppendToTail(100);
            node.AppendToTail(100);
            node.AppendToTail(100);
            node.AppendToTail(43);

            var expectedResult = new Node(100);
            expectedResult.AppendToTail(2);
            expectedResult.AppendToTail(52);
            expectedResult.AppendToTail(43);

            // Act
            var actualResult = removeDups.GetUniqueItems(node);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }

        [Fact]
        public void CanRemoveDupsFromOnlyDuplicateList()
        {
            // Arrange
            var removeDups = new RemoveDups();
            var node = new Node(1);
            node.AppendToTail(1);
            node.AppendToTail(1);
            node.AppendToTail(1);
            node.AppendToTail(1);

            var expectedResult = new Node(1);

            // Act
            var actualResult = removeDups.GetUniqueItems(node);

            // Assert
            Assert.Equal(expectedResult.GetData(), actualResult.GetData());
        }
    }
}