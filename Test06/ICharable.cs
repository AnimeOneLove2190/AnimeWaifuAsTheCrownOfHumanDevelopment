using System;
using System.Collections.Generic;
using System.Text;

namespace Test06Feature542
{
    interface ICharable
    {
        public Dictionary<char, int> GetCharStatistics(string text);
    }
}
