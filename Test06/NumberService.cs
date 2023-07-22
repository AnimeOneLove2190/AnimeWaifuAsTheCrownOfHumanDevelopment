using System;
using System.Collections.Generic;
using System.Text;

namespace Test06
{
    class NumberService
    {
        public double GetWhat(int inputNum, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }
            double result = (double)inputNum;
            if (degree > 0)
            {
                for (int i = 1; i < degree; i++)
                {
                    result = result * inputNum;
                }
            }
            if (degree < 0)
            {
                result = 1;
                for (int i = 0; i > degree; i--)
                {
                    result = result / (double)inputNum;
                }
            }
            return result;
        }
    }
}
