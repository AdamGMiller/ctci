using ctci._10.SortingAndSearching;

namespace citi.Tests._10.SortingAndSearching
{
    public class SearchInRotatedArrayTests
    {
        [Fact]
        public void FindsIndexForRotatedArray()
        {
            // Arrange
            var a = new[] { 6, 10, 14, 1, 2, 3, 4, 5 };
            var searchFor = 3;
            var searchInRotatedArray = new SearchInRotatedArray(a);
            var expectedResult = 5;

            // Act
            var index = searchInRotatedArray.FindIndex(searchFor);

            // Assert
            Assert.Equal(expectedResult, index);
        }

        [Fact]
        public void FindsIndexForNonRotatedArray()
        {
            // Arrange
            var a = new[] { 1, 2, 3, 4, 5, 10, 20, 30 };
            var searchFor = 3;
            var searchInRotatedArray = new SearchInRotatedArray(a);
            var expectedResult = 2;

            // Act
            var index = searchInRotatedArray.FindIndex(searchFor);

            // Assert
            Assert.Equal(expectedResult, index);
        }

        [Fact]
        public void ReturnNegativeOneWhenNotExists()
        {
            // Arrange
            var a = new[] { 100, 2, 3, 4, 5, 10, 20, 30 };
            var searchFor = 1;
            var searchInRotatedArray = new SearchInRotatedArray(a);
            var expectedResult = -1;

            // Act
            var index = searchInRotatedArray.FindIndex(searchFor);

            // Assert
            Assert.Equal(expectedResult, index);
        }
    }
}
