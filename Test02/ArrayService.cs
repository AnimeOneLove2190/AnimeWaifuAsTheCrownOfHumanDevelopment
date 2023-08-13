using System;

namespace Test02Arrays4
{
    class ArrayService
    {
        public int[] RemoveLastElementFromArray(int[] array)
        {    
            if (array == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            int[] arrayWithoutElement = new int[array.Length - 1];
            for (int i = 0; i < arrayWithoutElement.Length; i++)
            {
                arrayWithoutElement[i] = array[i];
            }
            return arrayWithoutElement;
        }
        public Person[] RemoveLastElementFromArray(Person[] waifuArray)
        {
            if (waifuArray == null)
            {
                Console.WriteLine("Сработала защита");
                return null;
            }
            Person[] arrayWithoutElement = new Person[waifuArray.Length - 1];
            for (int i = 0; i < arrayWithoutElement.Length; i++)
            {
                    arrayWithoutElement[i] = waifuArray[i];
            }
            return arrayWithoutElement;
        }
    }
}
