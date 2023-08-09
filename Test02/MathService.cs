using System;
using System.Collections.Generic;
using System.Text;

namespace Test02Arrays4
{
    class MathService
    {
        public void FillArray(int[] inputArray)
        {
            Random godOfNumbers = new Random();
            for(int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = godOfNumbers.Next(0, 10);
            }
        }
    }
}
