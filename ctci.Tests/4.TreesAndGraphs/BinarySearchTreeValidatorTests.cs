using ctci._4.TreesAndGraphs;

namespace citi.Tests._4.TreesAndGraphs
{
    public class BinarySearchTreeValidatorTests
    {
        [Fact]
        public void ReturnsTrueWithPerfectBinarySearchTree()
        {
            // Arrange
            var root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);
            root.Left.Left = new TreeNode(1);
            root.Left.Right = new TreeNode(7);
            root.Right.Left = new TreeNode(12);
            root.Right.Right = new TreeNode(16);

            // Act
            var validator = new ctci._4.TreesAndGraphs.BinarySearchTreeValidator(root);
            var isValid = validator.IsValid();

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void ReturnsTrueWithImperfectBinarySearchTree()
        {
            // Arrange
            var root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);
            root.Left.Left = new TreeNode(1);
            root.Left.Right = new TreeNode(7);
            root.Right.Left = null;
            root.Right.Right = new TreeNode(16);

            // Act
            var validator = new ctci._4.TreesAndGraphs.BinarySearchTreeValidator(root);
            var isValid = validator.IsValid();

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void ReturnsFalseWithInvalidBinarySearchTree()
        {
            // Arrange
            var root = new TreeNode(10);
            root.Left = new TreeNode(5);
            root.Right = new TreeNode(15);
            root.Left.Left = new TreeNode(1);
            root.Left.Right = new TreeNode(18);
            root.Right.Left = new TreeNode(12);
            root.Right.Right = new TreeNode(16);

            // Act
            var validator = new ctci._4.TreesAndGraphs.BinarySearchTreeValidator(root);
            var isValid = validator.IsValid();

            // Assert
            Assert.False(isValid);
        }
    }
}
