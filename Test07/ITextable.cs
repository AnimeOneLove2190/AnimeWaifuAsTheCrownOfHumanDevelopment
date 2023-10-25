using System;
using System.Collections.Generic;
using System.Text;

namespace Test07
{
    interface ITextable
    {
        public Dictionary<string, int> GetWordStatistics(string text);
    }
}
