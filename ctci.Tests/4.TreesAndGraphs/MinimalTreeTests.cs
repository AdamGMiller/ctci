namespace citi.Tests._4.TreesAndGraphs
{
    using ctci._4.TreesAndGraphs;

    public class MinimalTreeTests
    {
        [Fact]
        public void GetsMinimalTreeDepthAsExpected()
        {
            // Arrange
            var sortedArray = new int[] { 11, 22, 33, 44, 55, 66, 77, 78, 79 };

            // Act
            var tree = new MinimalTree(sortedArray);
            var height = tree.GetActualTreeHeight();
            var optimalHeight = tree.GetOptimalTreeHeight(sortedArray.Length);

            // Assert
            Assert.Equal(height, 4);
            Assert.Equal(optimalHeight, 4);
        }

        [Fact]
        public void GetsMinimalTreeDepthOf100IntegersAsExpected()
        {
            // Arrange
            var sortedArray = Enumerable.Range(1, 100).ToArray();

            // Act
            var tree = new MinimalTree(sortedArray);
            var height = tree.GetActualTreeHeight();
            var optimalHeight = tree.GetOptimalTreeHeight(sortedArray.Length);

            // Assert
            Assert.Equal(height, 7);
            Assert.Equal(optimalHeight, 7);
        }
    }
}
