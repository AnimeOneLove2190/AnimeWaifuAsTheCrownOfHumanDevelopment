using System;
using System.Collections.Generic;
using System.Text;

namespace Test06
{
    class NumberService
    {
        public bool IsPrimeNumber(int inputNum)
        {
            if (inputNum == 1)
            {
                return false;
            }
            if (inputNum == 2)
            {
                return true;
            }
            for (int divider = 2; divider < inputNum; divider++)
            {
                if (inputNum % divider == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
