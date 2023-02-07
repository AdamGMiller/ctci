using System.Drawing;

namespace ctci._1.Strings
{
    public class Matrix
    {
        // 3x3 matrix clockwise rotation example
        // if c = 0 && r = 0, c = 2 && r = 0
        // if c = 1 && r = 0, c = 2 && r = 1
        // if c = 2 && r = 0, c = 2 && r = 2
        // if c = 0 && r = 1, c = 1 && r = 0
        // if c = 1 && r = 1, c = 1 && r = 1
        // if c = 2 && r = 1, c = 1 && r = 2


        public Color[,] RotateMatrix(Color[,] matrix)
        {
            var matrixSize = matrix.GetLength(0);
            var outputMatrix = new Color[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int column = 0; column < matrixSize; column++)
                {
                    var value = matrix[row, column];
                    var outputRow = column;
                    var outputColumn = matrixSize - row - 1;
                    outputMatrix[outputRow, outputColumn] = value;
                }
            }

            return outputMatrix;
        }
    }
}
