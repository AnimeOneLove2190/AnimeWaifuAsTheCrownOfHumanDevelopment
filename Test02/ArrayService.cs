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
        public int[,] Change2DArray(int[,] array2D, int newCountOfRows, int newCountOfColums)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[,] array2DWithNewLength = new int[newCountOfRows, newCountOfColums];
            for (int i = 0; i < newCountOfRows; i++)
            {
                for (int j = 0; j < newCountOfColums; j++)
                {
                    if (i < rows && j < columns)
                    {
                        array2DWithNewLength[i, j] = array2D[i, j];
                    }
                }
            }
            return array2DWithNewLength;
        }
    }
}
