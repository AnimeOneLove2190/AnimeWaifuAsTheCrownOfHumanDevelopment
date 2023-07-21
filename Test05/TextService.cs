using System;
using System.Collections.Generic;
using System.Text;

namespace Test05
{
    class TextService
    {
        public void ClearTextFile(TextFile personOne)
        {
            personOne.description = "Description deleted";
            personOne.weight = 0;
        }
    }
}
