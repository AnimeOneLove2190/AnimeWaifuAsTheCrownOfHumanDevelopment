using System;
using System.Collections.Generic;
using System.Text;

namespace Test03Feature532
{
    class Division : ICalculable
    {
        public int DoOperation(int numOne, int numTwo)
        {
            int result = numOne / numTwo;
            return result;
        }
    }
}
