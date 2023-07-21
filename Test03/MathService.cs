using System;
using System.Collections.Generic;
using System.Text;

namespace Test03
{
    class MathService
    {
        public int PerformOperation(int numberOne, int numberTwo, Operation operation)
        {
            int resultFin = 0;
            if (operation == (Operation)1)
            {
                int resultInt = numberOne + numberTwo;
                resultFin = resultInt;
            }
            if (operation == (Operation)2)
            {
                int resultInt = numberOne * numberTwo;
                resultFin = resultInt;
            }
            if (operation == (Operation)3)
            {
                int resultInt = numberOne / numberTwo;
                resultFin = resultInt;
            }
            if (operation == (Operation)4)
            {
                int resultInt = numberOne - numberTwo;
                resultFin = resultInt;
            }
            return resultFin;
        }
    }
}
