using System;
using System.Collections.Generic;
using System.Text;

namespace Test03Feature532
{
    class Addition : Calculate
    {
        public override int DoOperation(int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            return result;
        }
    }
}
