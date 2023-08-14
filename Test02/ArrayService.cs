using System;

namespace Test02Arrays4
{
    class ArrayService
    {
        public int[] RemoveSelectedSegmentFromArray(int[] array, int minValueSegment, int maxValueSegment)
        {    
            if (array == null || array.Length == 0)
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
                return array;
            }
            int[] deletedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < deletedSegment.Length; i++, j++)
            {
                deletedSegment[i] = j;
                if (deletedSegment[i] >= array.Length)
                {
                    return array;
                }
            }
            int[] arrayWithoutSegment = new int[array.Length - deletedSegment.Length];
            for (int i = 0, j = 0, z = 0; i < array.Length; i++)
            {
                if (z >= deletedSegment.Length)
                {
                    arrayWithoutSegment[j] = array[i];
                    j++;
                    continue;
                }
                if (deletedSegment[z] == i)
                {
                    z++;
                    continue;
                }
                arrayWithoutSegment[j] = array[i];
                j++;
            }
            return arrayWithoutSegment;
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
