using System;

namespace Test02Arrays4
{
    class ArrayService
    {
        public int[] RemoveSelectedValueFromArray(int[] array, int selectedValue)
        {    
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int countOfNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == selectedValue)
                {
                    countOfNumbers++;
                }
            }
            int[] arrayWithoutValues = new int[array.Length - countOfNumbers];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] == selectedValue)
                {
                    continue;
                }
                arrayWithoutValues[j] = array[i];
                j++;
            }
            return arrayWithoutValues;
        }
        public Person[] RemoveSelectedSegmentFromArray(Person[] waifuArray, int minValueSegment, int maxValueSegment)
        {
            if (waifuArray == null || waifuArray.Length == 0)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            if (maxValueSegment < minValueSegment)
            {
                int temporaryStorage = maxValueSegment;
                maxValueSegment = minValueSegment;
                minValueSegment = temporaryStorage;
            }
            if (minValueSegment < 0)
            {
                return waifuArray;
            }
            int[] deletedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < deletedSegment.Length; i++, j++)
            {
                deletedSegment[i] = j;
                if (deletedSegment[i] >= waifuArray.Length)
                {
                    return waifuArray;
                }
            }
            Person[] arrayWithoutSegment = new Person[waifuArray.Length - deletedSegment.Length];
            for (int i = 0, j = 0, z = 0; i < waifuArray.Length; i++)
            {
                if (z >= deletedSegment.Length)
                {
                    arrayWithoutSegment[j] = waifuArray[i];
                    j++;
                    continue;
                }
                if (deletedSegment[z] == i)
                {
                    z++;
                    continue;
                }
                arrayWithoutSegment[j] = waifuArray[i];
                j++;
            }
            return arrayWithoutSegment;
        }
    }
}
