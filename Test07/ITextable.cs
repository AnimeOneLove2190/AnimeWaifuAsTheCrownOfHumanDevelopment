using System;
using System.Collections.Generic;
using System.Text;

namespace Test07Feature542
{
    interface ITextable
    {
        public Dictionary<string, int> GetWordStatistics(string text);
    }
}
