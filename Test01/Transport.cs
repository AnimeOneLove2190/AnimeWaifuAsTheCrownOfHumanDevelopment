using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class Transport
    {
        public string Owner { get; set; }
        public int Speed { get; set; }
        public virtual string GetInfo ()
        {
            return $"Мой владелец: {Owner}. Моя скорость:{Speed}";
        }
    }
}

