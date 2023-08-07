using System;
using System.Collections.Generic;
using System.Text;

namespace Test02Arrays4
{
    class ArrayService
    {
        public void PrintArray(int[] array)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public int[] GetEvenArray(int[] array)
        {
            int countOfNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    countOfNumbers++;
                }
            }
            int[] evenArray = new int[countOfNumbers];
            for (int i = 0, j = 0; j < evenArray.Length && i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenArray[j] = array[i];
                    j++;
                }
            }
            return evenArray;
        }
    }
}
