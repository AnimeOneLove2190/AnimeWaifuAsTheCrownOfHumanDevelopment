using System;

namespace Test02Arrays4
{
    class ArrayService
    {
        public void CountRowsAndColums(int[,] array2D, out int rows, out int columns)
        {
            rows = array2D.GetUpperBound(0) + 1;
            columns = array2D.Length / rows;
        }
        public int[,] AddRowIn2DArray(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int newRows = rows + 1;
            int[,] array2DWithAddedRow = new int[newRows, columns];
            int[] addedColumn = new int[columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2DWithAddedRow[i, j] = array2D[i, j];
                }
            }
            for (int i = 0; i < columns; i++)
            {
                array2DWithAddedRow[newRows - 1, i] = addedColumn[i];
            }
            return array2DWithAddedRow;
        }
    }
}
