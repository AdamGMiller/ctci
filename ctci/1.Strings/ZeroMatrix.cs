namespace ctci._1.Strings
{
    public class ZeroMatrix
    {
        public int[,] SetRowsAndColumnsToZeroIfElementIsZero(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            bool[] rowHasZeroElements = new bool[rows];
            bool[] columnHasZeroElements = new bool[columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    var valueIsZero = matrix[row, column] == 0;

                    if (valueIsZero)
                    {
                        rowHasZeroElements[row] = true;
                        columnHasZeroElements[column] = true;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                if (rowHasZeroElements[row])
                {
                    SetRowToZero(row);
                }
            }

            for (int column = 0; column < columns; column++)
            {
                if (columnHasZeroElements[column])
                {
                    SetColumnToZero(column);
                }
            }

            return matrix;

            void SetRowToZero(int column)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, column] = 0;
                }
            }

            void SetColumnToZero(int row)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = 0;
                }
            }
        }
    }
}
