using ctci._4.TreesAndGraphs;

namespace citi.Tests._4.TreesAndGraphs
{
    public class CheckedBalancedTests
    {
        [Fact]
        public void ReturnsTrueWithBalancedTree()
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
            var balancedChecker = new CheckBalanced(root);
            var isBalanced = balancedChecker.IsBalanced();

            // Assert
            Assert.True(isBalanced);
        }

        [Fact]
        public void ReturnsFalseWithUnbalancedTree()
        {
            // Arrange
            var root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(7);

            // Act
            var balancedChecker = new CheckBalanced(root);
            var isBalanced = balancedChecker.IsBalanced();

            // Assert
            Assert.False(isBalanced);
        }
    }
}
