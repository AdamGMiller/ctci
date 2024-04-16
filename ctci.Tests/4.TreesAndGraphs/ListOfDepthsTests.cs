namespace citi.Tests._4.TreesAndGraphs
{
    using ctci._4.TreesAndGraphs;

    public class ListOfDepthsTests
    {
        [Fact]
        public void CreatesListOfDepthsAsExpected()
        {
                        // Arrange
            var root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(7);

            // Act
            var listOfDepths = new ListOfDepths(root);

            // Assert
            Assert.Equal(1, listOfDepths.Depths[0].First.Value.Data);
            Assert.Equal(2, listOfDepths.Depths[1].First.Value.Data);
            Assert.Equal(3, listOfDepths.Depths[1].Last.Value.Data);
            Assert.Equal(4, listOfDepths.Depths[2].First.Value.Data);
            Assert.Equal(7, listOfDepths.Depths[2].Last.Value.Data);
        }

        [Fact]
        public void CreatesListOfDepthsForIncompleteTreeAsExpected()
        {
            // Arrange
            var root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Right.Right = new TreeNode(7);
            root.Right.Right.Left = new TreeNode(8);
            root.Right.Right.Left.Left = new TreeNode(9);

            // Act
            var listOfDepths = new ListOfDepths(root);

            // Assert
            Assert.Equal(1, listOfDepths.Depths[0].First.Value.Data);
            Assert.Equal(2, listOfDepths.Depths[1].First.Value.Data);
            Assert.Equal(3, listOfDepths.Depths[1].Last.Value.Data);
            Assert.Equal(7, listOfDepths.Depths[2].First.Value.Data);
            Assert.Equal(8, listOfDepths.Depths[3].First.Value.Data);
            Assert.Equal(9, listOfDepths.Depths[4].First.Value.Data);
        }
    }
}
