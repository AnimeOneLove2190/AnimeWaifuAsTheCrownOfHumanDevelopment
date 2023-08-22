using System;
using System.Collections.Generic;
using System.Text;

namespace Test02Arrays4
{
    class TechnicalService
    {
        public int[,] Create2DArray(int countOfStrings, int countOfColums, int minValue, int maxValue)
        {
            Random godOfNumbers = new Random();
            int[,] array2D = new int[countOfStrings, countOfColums];
            for (int i = 0; i < countOfStrings; i++)
            {
                for (int j = 0; j < countOfColums; j++)
                {
                    array2D[i, j] = godOfNumbers.Next(minValue, maxValue);
                }
            }
            return array2D;
        }
        public void CountRowsAndColums(int[,] array2D, out int rows, out int columns)
        {
            rows = array2D.GetUpperBound(0) + 1;
            columns = array2D.Length / rows;
        }
        public void Write2DArray(int[,] array2D)
        {
            if (array2D == null || array2D.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            int rows;
            int columns;
            CountRowsAndColums(array2D, out rows, out columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public void Write1DArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public void CountRowsAndColums3D(int[,,] array3D, out int rows, out int columns, int lines)
        {
            rows = array3D.GetUpperBound(0) + 1;
            columns = (array3D.Length / rows) / lines;
        }
        public int[,,] Create3DArray(int countOfStrings, int countOfColums, int countOfLines, int minValue, int maxValue)
        {
            Random godOfNumbers = new Random();
            int[,,] array3D = new int[countOfStrings, countOfColums, countOfLines];
            for (int i = 0; i < countOfStrings; i++)
            {
                for (int j = 0; j < countOfColums; j++)
                {
                    for (int z = 0; z < countOfLines; z++)
                    {
                        array3D[i, j, z] = godOfNumbers.Next(minValue, maxValue);
                    }
                }
            }
            return array3D;
        }
        public void Write3DArray(int[,,] array3D, int countOfLines)
        {
            if (array3D == null || array3D.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            int rows;
            int columns;
            CountRowsAndColums3D(array3D, out rows, out columns, countOfLines);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int z = 0; z < countOfLines; z++)
                    {
                        Console.Write($"{array3D[i, j, z]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
