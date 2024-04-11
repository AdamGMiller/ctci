namespace citi.Tests._1.Strings
{
    using System.Drawing;

    using ctci._1.Strings;

    public class RotateMatrixTests
    {
        [Fact]
        public void RotateMatrixWorksWith2x2Matrix()
        {
            // Arrange
            Color[,] inputMatrix = new Color[2, 2]  {
                { Color.Red, Color.Blue },
                { Color.Red, Color.Purple }
            };
            Color[,] expectedOutput = new Color[2, 2] {
                { Color.Red, Color.Red },
                { Color.Purple, Color.Blue }
            };

            var matrix = new Matrix();

            // Act
            var actualOutput = matrix.RotateMatrix(inputMatrix);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void RotateMatrixWorksWith3x3Matrix()
        {
            // Arrange
            Color[,] inputMatrix = new Color[3, 3]  {
                { Color.Red, Color.Blue, Color.Blue },
                { Color.Green, Color.Yellow, Color.Blue },
                { Color.Red, Color.Blue, Color.Purple },
            };
            Color[,] expectedOutput = new Color[3, 3] {
                { Color.Red, Color.Green, Color.Red },
                { Color.Blue, Color.Yellow, Color.Blue},
                { Color.Purple, Color.Blue, Color.Blue },
            };

            var matrix = new Matrix();

            // Act
            var actualOutput = matrix.RotateMatrix(inputMatrix);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void RotateMatrixWorksWith4x4Matrix()
        {
            // Arrange
            Color[,] inputMatrix = new Color[4, 4]  {
                { Color.Red, Color.Blue, Color.Blue, Color.Black },
                { Color.Green, Color.Yellow, Color.Blue, Color.Black },
                { Color.Red, Color.Blue, Color.Blue, Color.Black },
                { Color.Orange, Color.Orange, Color.Orange, Color.Orange },
            };
            Color[,] expectedOutput = new Color[4, 4] {
                { Color.Orange, Color.Red, Color.Green,  Color.Red },
                { Color.Orange, Color.Blue, Color.Yellow,  Color.Blue },
                { Color.Orange, Color.Blue, Color.Blue,  Color.Blue },
                { Color.Orange, Color.Black, Color.Black,  Color.Black },
            };

            var matrix = new Matrix();

            // Act
            var actualOutput = matrix.RotateMatrix(inputMatrix);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}