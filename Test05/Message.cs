﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test05Feature534
{
    abstract class Message
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public abstract string Send();
    }
}
