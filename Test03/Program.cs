using System;
using System.Collections.Generic;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cond = new DateTime(2015, 01, 02) > new DateTime(2015, 01, 01, 23, 59, 59);
            Console.WriteLine(cond);
            Console.WriteLine(new DateTime(2015, 01, 01));
        }
    }
}
