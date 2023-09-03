using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class TechnicalService
    {
        public void WriteList(List<string> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public void WriteList(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Name: {list[i].Name}, Age: {list[i].Age}, Weight: {list[i].Weight}, Height: {list[i].Height}");
            }
        }
        public void BubbleSort(char[] charArray)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray.Length - i - 1; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        int temporaryStorage = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = (char)temporaryStorage;
                    }
                }
            }
        }
        public void BubbleSort(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < numberArray.Length - i - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        int temporaryStorage = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = temporaryStorage;
                    }
                }
            }
        }
    }
}

