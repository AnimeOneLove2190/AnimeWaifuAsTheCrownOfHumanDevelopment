using System;
using System.Collections.Generic;
using System.Text;

namespace Test06
{
    interface ICharable
    {
        public Dictionary<char, int> GetCharStatistics(string text);
    }
}
