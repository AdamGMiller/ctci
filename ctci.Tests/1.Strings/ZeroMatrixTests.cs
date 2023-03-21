using ctci._1.Strings;

namespace citi.Tests._1.Strings
{
    public partial class StringTests
    {
        [Fact]
        public void ZeroMatrixWith3x3AndCenterZero()
        {
            // Arrange
            int[,] inputMatrix = new int[3, 3]  {
                { 1, 1, 1 },
                { 1, 0, 1 },
                { 1, 1, 1 },
            };
            int[,] expectedOutput = new int[3, 3]  {
                { 1, 0, 1 },
                { 0, 0, 0 },
                { 1, 0, 1 },
            };

            var matrix = new ZeroMatrix();

            // Act
            var actualOutput = matrix.SetRowsAndColumnsToZeroIfElementIsZero(inputMatrix);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ZeroMatrixWith3x3AndNoZeros()
        {
            // Arrange
            int[,] inputMatrix = new int[3, 3]  {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 },
            };
            int[,] expectedOutput = new int[3, 3]  {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 },
            };

            var matrix = new ZeroMatrix();

            // Act
            var actualOutput = matrix.SetRowsAndColumnsToZeroIfElementIsZero(inputMatrix);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void ZeroMatrixWith3x3AndAllZeros()
        {
            // Arrange
            int[,] inputMatrix = new int[3, 3]  {
                { 0,0,0 },
                { 0,0,0 },
                { 0,0,0 },
            };
            int[,] expectedOutput = new int[3, 3]  {
                { 0,0,0 },
                { 0,0,0 },
                { 0,0,0 },
            };

            var matrix = new ZeroMatrix();

            // Act
            var actualOutput = matrix.SetRowsAndColumnsToZeroIfElementIsZero(inputMatrix);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}