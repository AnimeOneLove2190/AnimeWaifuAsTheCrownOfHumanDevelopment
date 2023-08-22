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
        public int[] CreateChimera(int[,] array2D)
        {
            if (array2D == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            int[] chimera = new int[array2D.Length];
            for (int z = 0; z < chimera.Length;)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        chimera[z] = array2D[i, j];
                        z++;
                    }
                }
            }
            return chimera;
        }
    }
}
