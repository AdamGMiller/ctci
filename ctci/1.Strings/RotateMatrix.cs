using System.Drawing;

namespace ctci._1.Strings
{
    public class Matrix
    {
        public Color[,] RotateMatrix(Color[,] matrix)
        {
            var matrixSize = matrix.GetLength(0);
            var outputMatrix = new Color[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int column = 0; column < matrixSize; column++)
                {
                    var value = matrix[row, column];
                    var outputRow = matrixSize - column - 1;
                    var outputColumn = matrixSize - row - 1;
                    outputMatrix[outputRow, outputColumn] = value;

                    // 2x2 matrix
                    // if w = 0 && h = 0, w = matrixSize && h = 0
                    // if w = 1 && h = 0, w = 1 && h = 1
                    // if w = 0 && h = 1, w = 0 && h = 0
                    // if w = 1 && h = 1, w = 0 && h = 1

                    // 3x3 matrix
                    // if w = 0 && h = 0, w = matrixSize && h = 0
                    // if w = 1 && h = 0, w = matrixSize - 0 && h = matrixSize - 1
                    // if w = 0 && h = 1, w = matrixSize - h && h = matrixSize - 0
                    // if w = 1 && h = 1, w = 0 && h = 1


                }
            }

            return outputMatrix;
        }
    }
}
