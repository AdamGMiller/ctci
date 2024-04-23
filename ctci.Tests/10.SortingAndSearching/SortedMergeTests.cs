namespace citi.Tests._10.SortingAndSearching
{
    using ctci._10.SortingAndSearching;
    public class SortedMergeTests
    {
        [Fact]
        public void CanSortAsExpected()
        {
            // Arrange
            var a = new[] { 1, 3, 5 };
            var b = new[] { 2, 4 };
            var sortedMerge = new SortedMerge(a, b);
            var expectedResult = new[] { 1, 2, 3, 4, 5 };

            // Act
            var result = sortedMerge.GetMergedArray();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CanSortAsExpectedWithEmptyBArray()
        {
            // Arrange
            var a = new[] { 1, 2, 3, 4, 5 };
            var b = new int[] {  };
            var sortedMerge = new SortedMerge(a, b);
            var expectedResult = new[] { 1, 2, 3, 4, 5 };

            // Act
            var result = sortedMerge.GetMergedArray();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CanSortAsExpectedWithEmptyAArray()
        {
            // Arrange
            var a = new int[] { };
            var b = new[] { 1, 2, 3, 4, 5 };
            var sortedMerge = new SortedMerge(a, b);
            var expectedResult = new[] { 1, 2, 3, 4, 5 };

            // Act
            var result = sortedMerge.GetMergedArray();

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}