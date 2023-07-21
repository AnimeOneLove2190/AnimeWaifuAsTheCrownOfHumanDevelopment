using System;
using System.Collections.Generic;
using System.Text;

namespace Test06
{
    class NumberService
    {
        public int FindMinNumbers(int inputNum)
        {
            Random random = new Random();
            int numMin = int.MaxValue;
            int result = 0;
            for (int i = 0; i < inputNum; i++)
            {
                int numOne = random.Next(int.MinValue, int.MaxValue);
                if (numOne <= numMin)
                {
                    int numMax = numMin;
                    numMin = numOne;
                    numOne = numMax;
                    result = numMin;
                }
            }
            return result;
        }
    }
}
