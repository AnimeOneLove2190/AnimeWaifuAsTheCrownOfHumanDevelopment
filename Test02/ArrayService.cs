using System;
using System.Collections.Generic;
using System.Text;

namespace Test02Arrays4
{
    class ArrayService
    {
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public double GetAverageAge(Person[] waifuArray)
        {
            int sum = 0;
            for (int i = 0; i < waifuArray.Length; i++)
            {
                Person person = waifuArray[i];
                sum += person.age;
            }
            double averageAge = (double)sum / waifuArray.Length;
            return averageAge;
        }
    }
}
