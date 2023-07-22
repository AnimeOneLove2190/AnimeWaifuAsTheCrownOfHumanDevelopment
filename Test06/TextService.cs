using System;
using System.Collections.Generic;
using System.Text;

namespace Test06
{
    class TextService
    {
        public string AddText(string previousResult, int numAdd)
        {
            string result = $"{previousResult}{numAdd}";
            return result;
        }
    }
}
