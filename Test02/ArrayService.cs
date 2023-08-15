using System;

namespace Test02Arrays4
{
    class ArrayService
    {
        public int[] PullOutSelectedSegmentFromArray(int[] array, int minValueSegment, int maxValueSegment)
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
            int[] selectedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < selectedSegment.Length; i++, j++)
            {
                selectedSegment[i] = j;
                if (selectedSegment[i] >= array.Length)
                {
                    return array;
                }
            }
            int[] pullOutSegment = new int[selectedSegment.Length];
            for (int i = 0, j = 0; i < array.Length && j < selectedSegment.Length; i++)
            {
                if (selectedSegment[j] == i)
                {
                    pullOutSegment[j] = array[i];
                    j++;
                }
            }
            return pullOutSegment;
        }
        public Person[] PullOutSelectedSegmentFromArray(Person[] waifuArray, int minValueSegment, int maxValueSegment)
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
            int[] selectedSegment = new int[maxValueSegment - minValueSegment + 1];
            for (int i = 0, j = minValueSegment; i < selectedSegment.Length; i++, j++)
            {
                selectedSegment[i] = j;
                if (selectedSegment[i] >= waifuArray.Length)
                {
                    return waifuArray;
                }
            }
            Person[] pullOutSegment = new Person[selectedSegment.Length];
            for (int i = 0, j = 0; i < waifuArray.Length && j < selectedSegment.Length; i++)
            {
                if (selectedSegment[j] == i)
                {
                    pullOutSegment[j] = waifuArray[i];
                    j++;
                }
            }
            return pullOutSegment;
        }
    }
}
