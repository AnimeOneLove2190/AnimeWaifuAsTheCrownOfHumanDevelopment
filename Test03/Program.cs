using System;
using System.Collections.Generic;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random godOfNumbers = new Random();
            List<int> numberList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numberList.Add(godOfNumbers.Next(0, 10));
            }
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }
    }
}
