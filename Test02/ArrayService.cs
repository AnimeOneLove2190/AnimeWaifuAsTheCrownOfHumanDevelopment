using System;

namespace Test02Arrays4
{
    class ArrayService
    {
        public void PrintArrayNumber(int[] array)
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
            Console.WriteLine();
        }
        public int[] GetArraySum(int[] arrayOne, int[] arrayTwo)
        {
            if ((arrayOne == null || arrayOne.Length == 0) && ((arrayTwo == null || arrayTwo.Length == 0)))
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arraySum = null;
            if (arrayOne.Length == arrayTwo.Length)
            {
                arraySum = new int[arrayOne.Length];
                for (int i = 0; i < arraySum.Length; i++)
                {
                    arraySum[i] = arrayOne[i] + arrayTwo[i];
                }
                return arraySum;
            }
            if (arrayOne.Length > arrayTwo.Length)
            {
                arraySum = new int[arrayOne.Length];
                for (int i = 0, j = 0; i < arrayOne.Length; i++, j++)
                {
                    if (j < arrayTwo.Length)
                    {
                        arraySum[i] = arrayOne[i] + arrayTwo[i];
                    }
                    else
                    {
                        arraySum[i] = arrayOne[i];
                    }
                }
            }
            if (arrayOne.Length < arrayTwo.Length)
            {
                arraySum = new int[arrayOne.Length];
                for (int i = 0, j = 0; i < arrayOne.Length; i++, j++)
                {
                    if (j < arrayOne.Length)
                    {
                        arraySum[i] = arrayOne[i] + arrayTwo[i];
                    }
                    else
                    {
                        arraySum[i] = arrayTwo[i];
                    }
                }
            }
            return arraySum;
        }
    }
}
