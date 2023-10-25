using System;
using System.Collections.Generic;
using System.Text;

namespace Test03
{
    class Multiplication : ICalculable
    {
        public int DoOperation(int numOne, int numTwo)
        {
            int result = numOne * numTwo;
            return result;
        }
    }
}
